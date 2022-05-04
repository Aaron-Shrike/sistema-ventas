using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;
using System.Data;
using AccesoDatos;

namespace ReglasNegocio
{
    public class RNPersonal
    {
    // ingles: MM/dd/yyyy: 10/25/2020, 01/15/2020
    // español: dd/MM/yyyy: 25/10/2020, 15/01/2020
    // estándar: yyyyMMdd: 20201025, 20200115


        public void Registrar(Personal personal)
        {
        //      string sql = $@"INSERT INTO Personal( Nombres, ApellidoPaterno, ApellidoMaterno, DNI, 
        //                FechaNacimiento, Celular, Correo, Vigente)
        //            VALUES('{personal.Nombres}', '{personal.ApellidoPaterno}', '{personal.ApellidoMaterno}',
        //                '{personal.DNI}', '{personal.FechaNacimiento:yyyyMMdd}', '{personal.Celular}', 
        //                '{personal.Correo}', 1)";
            string sql = @"INSERT INTO Personal( Nombres, ApellidoPaterno, ApellidoMaterno, DNI, FechaNacimiento, 
                    Celular, Correo, Vigencia) VALUES('" + personal.Nombres + "','" + personal.ApellidoPaterno +
                    "','" + personal.ApellidoMaterno + "','" + personal.DNI + "','" + personal.FechaNacimiento.ToString("yyyyMMdd") +
                    "','" + personal.Celular + "','" + personal.Correo + "', 1)";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    dal.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(Personal personal)
        {
            string sql = "UPDATE Personal SET Nombres = '" + personal.Nombres + "', ApellidoPaterno = '"
                + personal.ApellidoPaterno + "', ApellidoMaterno = '" + personal.ApellidoMaterno + "', DNI = '"
                + personal.DNI + "', Celular = '" + personal.Celular + "', Correo = '" + personal.Correo
                + "', Vigencia = " + (personal.Vigente == true ? 1 : 0) + " WHERE Codigo = " + personal.Codigo;
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    dal.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Personal> Listar()
        {
            List<Personal> trabajadores;
            string sql =
                @"SELECT P.Codigo, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.Celular, P.Correo
                    FROM Personal P
                    ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        trabajadores = new List<Personal>();
                        while (dr.Read() == true)
                        {
                            trabajadores.Add(new Personal()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                Celular = dr.GetString(dr.GetOrdinal("Celular"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return trabajadores;
        }

        public Personal Leer(int codigo)
        {
            Personal per = null;
            string sql = "SELECT P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.DNI, P.FechaNacimiento, P.Celular, P.Correo, P.Vigencia " +
                    "FROM Personal P WHERE P.Codigo = " + codigo;
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            per = new Personal()
                            {
                                Codigo = codigo,
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                Vigente = dr.GetBoolean(dr.GetOrdinal("Vigencia"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return per;
        }

        public List<Personal> ListarVigentes()
        {
            List<Personal> trabajadores;
            string sql =
                @"SELECT P.Codigo, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres
                    FROM Personal P WHERE P.Vigencia = 1
                    ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        trabajadores = new List<Personal>();
                        while (dr.Read() == true)
                        {
                            trabajadores.Add(new Personal()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")), 
                                Vigente  = true 
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return trabajadores;
        }


    }
}
