using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entidades;
using AccesoDatos;

namespace ReglasNegocio
{
    public class RNLocal
    {
        public void Registrar(Local local)
        {
            string sql = @"INSERT INTO Local(CodigoEmpresa, Nombre, Direccion, Telefono, Vigencia) VALUES('" +
                        local.Empresa.Codigo + "','" + local.Nombre + "','" + local.Direccion + "','" + local.Telefono +
                        "', 1)";
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

        public void Actualizar(Local local)
        {
            string sql = "UPDATE Local SET CodigoEmpresa = '" + local.Empresa.Codigo + "', Nombre = '"
                + local.Nombre + "', Direccion = '" + local.Direccion + "', Telefono = '"
                + local.Telefono + "', Vigencia = " + (local.Vigente == true ? 1 : 0)
                + " WHERE Codigo = " + local.Codigo;
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

        public Local Leer(int codigo)
        {
            Local loc = null;
            string sql = "SELECT CodigoEmpresa, Nombre, Direccion, Telefono, Vigencia " +
                    "FROM Local WHERE Codigo = " + codigo;
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            loc = new Local()
                            {
                                Codigo = codigo,
                                Empresa = new Empresa{
                                   Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEmpresa"))
                                },
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
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

            return loc;
        }

        public List<Local> Listar()
        {
            List<Local> locales;
            string sql = @"SELECT L.Codigo, E.RazonSocial, L.Nombre, L.Direccion, L.Telefono FROM Local L JOIN Empresa E 
                        ON E.Codigo=L.CodigoEmpresa ORDER BY L.Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        locales = new List<Local>();
                        while (dr.Read() == true)
                        {
                            locales.Add(new Local()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Empresa = new Empresa
                                {
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"))
                                },
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                Telefono = dr.GetString(dr.GetOrdinal("Telefono"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return locales;
        }

        public List<Local> ListarVigentes()
        {

            List<Local> locales;
            string sql = @"SELECT Codigo, Nombre FROM Local WHERE Vigencia = 1
                    ORDER BY Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        locales = new List<Local>();
                        while (dr.Read() == true)
                        {
                            locales.Add(new Local()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Vigente = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return locales;

        }
    }
}
