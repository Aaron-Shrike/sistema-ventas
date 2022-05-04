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
    public class RNCategoria
    {
        public void Registrar(Categoria categoria)
        {
            string sql = @"INSERT INTO Categoria(CodigoEmpresa, Nombre, Descripcion, Vigencia) VALUES('" + 
                        categoria.Empresa.Codigo+ "','" + categoria.Nombre + "','" + categoria.Descripcion + "', 1)";
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

        public void Actualizar(Categoria categoria)
        {
            string sql = @"UPDATE Categoria SET CodigoEmpresa = '" + categoria.Empresa.Codigo + "', Nombre = '" + 
                    categoria.Nombre + "', Descripcion = '" + categoria.Descripcion + 
                    "', Vigencia = " + (categoria.Vigente == true ? 1 : 0) + " WHERE Codigo = " + categoria.Codigo;
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

        public List<Categoria> Listar()
        {
            List<Categoria> categorias;
            string sql = @"SELECT C.Codigo, E.RazonSocial, C.Nombre, C.Descripcion FROM Categoria C JOIN Empresa E 
                        ON E.Codigo=C.CodigoEmpresa ORDER BY C.Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        categorias = new List<Categoria>();
                        while (dr.Read() == true)
                        {
                            categorias.Add(new Categoria()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Empresa = new Empresa{
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"))
                                },
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categorias;
        }

        public Categoria Leer(int codigo)
        {
            Categoria cat = null;
            string sql = "SELECT CodigoEmpresa, Nombre, Descripcion, Vigencia " +
                    "FROM Categoria WHERE Codigo = " + codigo;
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            cat = new Categoria()
                            {
                                Codigo = codigo,
                                Empresa = new Empresa{
                                    Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEmpresa")),
                                },
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
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

            return cat;
        }

        public List<Categoria> ListarVigentes()
        {
            List<Categoria> categorias;
            string sql = @"SELECT Codigo, Nombre FROM Categoria WHERE Vigencia = 1
                    ORDER BY Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        categorias = new List<Categoria>();
                        while (dr.Read() == true)
                        {
                            categorias.Add(new Categoria()
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

            return categorias;
        }

        public List<Categoria> ListarCategorias(int codEmpresa)
        {
            List<Categoria> categorias;
            string sql = @"SELECT Codigo, Nombre FROM Categoria WHERE CodigoEmpresa = '"+ codEmpresa +"' AND Vigencia = 1 ORDER BY Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        categorias = new List<Categoria>();
                        while (dr.Read() == true)
                        {
                            categorias.Add(new Categoria()
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

            return categorias;
        }
    }
}
