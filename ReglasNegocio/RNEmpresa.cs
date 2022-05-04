using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Entidades;
using AccesoDatos;

namespace ReglasNegocio
{
    public class RNEmpresa
    {

        public void Registrar(Empresa empresa)
        {
            string sql = @"INSERT INTO Empresa(RazonSocial, RUC, Facebook, Instagram, Youtube, Whatsapp, Correo, Logo, Vigencia) 
                        VALUES('" + empresa.RazonSocial + "','" + empresa.Ruc + "','" + empresa.Facebook + "','" + empresa.Instagram +
                        "','" + empresa.Youtube + "','" + empresa.Whatsapp + "','" + empresa.Correo + "','" + empresa.Logo + "', 1)";
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

        public void Actualizar(Empresa empresa)
        {
            string sql = @"UPDATE Empresa SET RazonSocial = '" + empresa.RazonSocial + "', RUC = '" + empresa.Ruc + 
                    "', Facebook = '" + empresa.Facebook + "', Instagram = '" + empresa.Instagram +
                    "', Youtube = '" + empresa.Youtube + "', Whatsapp = '" + empresa.Whatsapp +
                    "', Correo = '" + empresa.Correo + "', Logo = '" + empresa.Logo + 
                    "', Vigencia = " + (empresa.Vigente == true ? 1 : 0) + " WHERE Codigo = " + empresa.Codigo;
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

        public List<Empresa> Listar()
        {
            List<Empresa> empresas;
            string sql = @"SELECT Codigo, RazonSocial, RUC, Correo FROM Empresa
                ORDER BY RazonSocial";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        empresas = new List<Empresa>();
                        while (dr.Read() == true)
                        {
                            empresas.Add(new Empresa()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                Ruc = dr.GetString(dr.GetOrdinal("RUC")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empresas;
        }

        public Empresa Leer(int codigo)
        {
            Empresa emp = null;
            string sql = "SELECT RazonSocial, RUC, Facebook, Instagram, Youtube, Whatsapp, Correo, Logo, Vigencia " +
                    "FROM Empresa WHERE Codigo = " + codigo;

            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            emp = new Empresa()
                            {
                                Codigo = codigo,
                                RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                Ruc = dr.GetString(dr.GetOrdinal("RUC")),
                                Facebook = dr.GetString(dr.GetOrdinal("Facebook")),
                                Instagram = dr.GetString(dr.GetOrdinal("Instagram")),
                                Youtube = dr.GetString(dr.GetOrdinal("Youtube")),
                                Whatsapp = dr.GetString(dr.GetOrdinal("Whatsapp")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                Logo = dr.GetString(dr.GetOrdinal("Logo")),
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

            return emp;
        }

        public List<Empresa> ListarVigentes()
        {
            List<Empresa> empresas;
            string sql = @"SELECT Codigo, RazonSocial FROM Empresa WHERE Vigencia = 1
                    ORDER BY RazonSocial";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        empresas = new List<Empresa>();
                        while (dr.Read() == true)
                        {
                            empresas.Add(new Empresa()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
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

            return empresas;
        }
    }
}
