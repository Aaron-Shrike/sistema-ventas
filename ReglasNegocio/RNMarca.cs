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
    public class RNMarca
    {
        public void Registrar(Marca marca)
        {
            string sql = @"INSERT INTO Marca(Nombre, Vigencia) VALUES('" + marca.Nombre + "', 1)";
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

        public void Actualizar(Marca marca)
        {
            string sql = @"UPDATE Marca SET Nombre = '" + marca.Nombre + 
                    "', Vigencia = " + (marca.Vigente == true ? 1 : 0) + " WHERE Codigo = " + marca.Codigo;
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

        public List<Marca> Listar()
        {
            List<Marca> marcas;
            string sql = @"SELECT Codigo, Nombre, Vigencia FROM Marca ORDER BY Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        marcas = new List<Marca>();
                        while (dr.Read() == true)
                        {
                            marcas.Add(new Marca()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Vigente = dr.GetBoolean(dr.GetOrdinal("Vigencia"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return marcas;
        }

        public Marca Leer(int codigo)
        {
            Marca mar = null;
            string sql = "SELECT Nombre, Vigencia FROM Marca WHERE Codigo = " + codigo;
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            mar = new Marca()
                            {
                                Codigo = codigo,
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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

            return mar;
        }

        public List<Marca> ListarVigentes()
        {
            List<Marca> marcas;
            string sql = @"SELECT Codigo, Nombre FROM Marca WHERE Vigencia = 1 ORDER BY Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        marcas = new List<Marca>();
                        while (dr.Read() == true)
                        {
                            marcas.Add(new Marca()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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

            return marcas;
        }
    }
}
