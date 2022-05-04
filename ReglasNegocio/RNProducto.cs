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
    public class RNProducto
    {
        public void Registrar(Producto producto)
        {
            string sql = @"INSERT INTO producto(CodigoCategoria,CodigoMarca,Tipo,Negociable,Nombre,TipoControl,Vigencia)
            VALUES('" + producto.Categoria.Codigo + "','" + producto.Marca.Codigo + "','" + producto.Tipo + "'," + producto.Negociable + ",'"
            + producto.Nombre + "','" + producto.TipoControl + "'," + producto.Vigencia + ")";

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

        public void Actualizar(Producto producto)
        {
            string sql = "UPDATE producto SET CodigoCategoria = '" + producto.Categoria.Codigo + "',CodigoMarca = '" + producto.Marca.Codigo + "',Tipo = '"
            + producto.Tipo + "',Negociable = " + producto.Negociable + ",Nombre = '" + producto.Nombre + "',TipoControl = '"
            + producto.TipoControl + "',Vigencia = " + producto.Vigencia + " WHERE Codigo = '" + producto.Codigo + "'";

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

        public List<Producto> Listar()
        {
            List<Producto> productos = null;
            string sql = @"SELECT P.Codigo,C.Nombre as NombreCategoria,M.Nombre as NombreMarca,P.Tipo,P.Negociable,P.Nombre,P.TipoControl,P.Vigencia FROM Producto P JOIN Categoria C ON P.CodigoCategoria = C.Codigo JOIN Marca M ON P.CodigoMarca = M.Codigo";

            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        productos = new List<Producto>();
                        while (dr.Read() == true)
                        {
                            productos.Add(
                              new Producto
                              {

                                  Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                  Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                  Negociable = dr.GetBoolean(dr.GetOrdinal("Negociable")),
                                  Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                  TipoControl = dr.GetString(dr.GetOrdinal("TipoControl")),
                                  Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                  Categoria = new Categoria
                                  {
                                      Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria"))
                                  },
                                  Marca = new Marca
                                  {
                                      Nombre = dr.GetString(dr.GetOrdinal("NombreMarca"))
                                  }
                              }
                              );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productos;
        }

        public Producto Leer(int codigo)
        {
            Producto pro = null;
            string sql = @"SELECT P.Codigo,C.Nombre as NombreCategoria,M.Nombre as NombreMarca,P.Tipo,P.Negociable,P.Nombre,P.TipoControl,P.Vigencia FROM Producto P JOIN Categoria C ON P.CodigoCategoria = C.Codigo JOIN Marca M ON P.CodigoMarca = M.Codigo WHERE P.Codigo = '" + codigo + "'";

            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            pro = new Producto()
                            {
                                Codigo = codigo,
                                Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                Negociable = dr.GetBoolean(dr.GetOrdinal("Negociable")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                TipoControl = dr.GetString(dr.GetOrdinal("TipoControl")),
                                Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                Categoria = new Categoria
                                {
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria"))
                                },
                                Marca = new Marca
                                {
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreMarca"))
                                }
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pro;
        }

        public List<Producto> ListarVigentes()
        {

            List<Producto> productos;
            string sql = @"SELECT Codigo, Nombre FROM Producto WHERE Vigencia = 1
                    ORDER BY Nombre";
            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        productos = new List<Producto>();
                        while (dr.Read() == true)
                        {
                            productos.Add(new Producto()
                            {
                                Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Vigencia = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productos;


        }

        public List<Producto> Listar(int codCategoria, int codMarca)
        {
            List<Producto> productos = null;
            string sql = @"SELECT P.Codigo,C.Nombre as NombreCategoria,M.Nombre as NombreMarca,P.Tipo,P.Negociable,P.Nombre,P.TipoControl,P.Vigencia FROM Producto P JOIN Categoria C ON P.CodigoCategoria = C.Codigo JOIN Marca M ON P.CodigoMarca = M.Codigo ";
            if (codCategoria != -1 && codMarca != -1)
            {
                sql += "WHERE P.CodigoCategoria = '" + codCategoria + "' AND P.CodigoMarca = '" + codMarca + "'";
            }
            if (codCategoria == -1 && codMarca != -1)
            {
                sql += "WHERE P.CodigoMarca = '" + codMarca + "'";
            }
            if (codCategoria != -1 && codMarca == -1)
            {
                sql += "WHERE P.CodigoCategoria = '" + codCategoria + "'";
            }

            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        productos = new List<Producto>();
                        while (dr.Read() == true)
                        {
                            productos.Add(
                              new Producto
                              {

                                  Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                  Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                  Negociable = dr.GetBoolean(dr.GetOrdinal("Negociable")),
                                  Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                  TipoControl = dr.GetString(dr.GetOrdinal("TipoControl")),
                                  Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                  Categoria = new Categoria
                                  {
                                      Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria"))
                                  },
                                  Marca = new Marca
                                  {
                                      Nombre = dr.GetString(dr.GetOrdinal("NombreMarca"))
                                  }
                              }
                              );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productos;
        }
    }
}

