using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using AccesoDatos;
using System.Data;

namespace ReglasNegocio
{
    public class RNPrecioLocal
    {

        public void Registrar(PrecioLocal precioLocal)
        {
            string sql = @"INSERT INTO precioLocal(CodigoLocal,CodigoProducto,Precio,PrecioMinimo,TipoISC,ISC,IGV,Exonerado,Stock,Vigencia)
            VALUES('" + precioLocal.CodigoLocal.Codigo + "','" + precioLocal.CodigoProducto.Codigo + "','" + precioLocal.Precio + "','"
                      + precioLocal.PrecioMinimo + "','" + precioLocal.TipoISC + "','" + precioLocal.ISC + "','" + precioLocal.IGV + "','" + precioLocal.Exonerado + "','"
                      + precioLocal.Stock + "'," + precioLocal.Vigencia + ")";

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

        public void Actualizar(PrecioLocal precioLocal)
        {
            string sql = "UPDATE precioLocal SET CodigoLocal = '" + precioLocal.CodigoLocal.Codigo + "',CodigoProducto = '"
           + precioLocal.CodigoProducto.Codigo + "',Precio = '" + precioLocal.Precio + "',PrecioMinimo = '" + precioLocal.PrecioMinimo + "',TipoISC =  '" + precioLocal.TipoISC + "',ISC = '" + precioLocal.ISC + "', IGV = '" + precioLocal.IGV + "',Exonerado = '" + precioLocal.Exonerado + "',Stock = '" + precioLocal.Stock + "',Vigencia = " + precioLocal.Vigencia + " WHERE Codigo = '" + precioLocal.Codigo + "'";

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

        public List<PrecioLocal> Listar()
        {
            List<PrecioLocal> precioLocales = null;
            string sql = @"SELECT P.Codigo,L.Nombre as NombreLocal,R.Nombre as NombreProducto,P.Precio,P.PrecioMinimo,P.TipoISC,P.ISC,P.IGV,P.Exonerado,P.Stock,P.Vigencia
                           FROM precioLocal P JOIN Local L ON P.CodigoLocal = L.Codigo JOIN Producto R ON P.CodigoProducto = R.Codigo";

            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        precioLocales = new List<PrecioLocal>();
                        while (dr.Read() == true)
                        {
                            precioLocales.Add(
                              new PrecioLocal
                              {
                                  Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                  Precio = (double)dr.GetDecimal(dr.GetOrdinal("Precio")),
                                  PrecioMinimo = (double)dr.GetDecimal(dr.GetOrdinal("PrecioMinimo")),
                                  TipoISC = dr.GetString(dr.GetOrdinal("TipoISC")),
                                  ISC = (double)dr.GetDecimal(dr.GetOrdinal("ISC")),
                                  IGV = (double)dr.GetDecimal(dr.GetOrdinal("IGV")),
                                  Exonerado = (double)dr.GetDecimal(dr.GetOrdinal("Exonerado")),
                                  Stock = dr.GetInt16(dr.GetOrdinal("Stock")),
                                  Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                  CodigoLocal = new Local
                                  {
                                      Nombre = dr.GetString(dr.GetOrdinal("NombreLocal"))
                                  },
                                  CodigoProducto = new Producto
                                  {
                                      Nombre = dr.GetString(dr.GetOrdinal("NombreProducto"))
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

            return precioLocales;
        }

        public PrecioLocal Leer(int codigo)
        {
            PrecioLocal pre = null;
            string sql = @"SELECT P.Codigo,L.Nombre as NombreLocal,R.Nombre as NombreProducto,P.Precio,P.PrecioMinimo,P.TipoISC,P.ISC,P.IGV,P.Exonerado,P.Stock,P.Vigencia
                           FROM precioLocal P JOIN Local L ON P.CodigoLocal = L.Codigo JOIN Producto R ON P.CodigoProducto = R.Codigo WHERE P.Codigo = '" + codigo + "'";

            try
            {
                using (DAL dal = new DAL(Properties.Settings.Default.Fabrica, Properties.Settings.Default.Conexion))
                {
                    using (IDataReader dr = dal.EjecutarOrden(sql, true))
                    {
                        if (dr.Read() == true)
                        {
                            pre = new PrecioLocal()
                            {
                                Codigo = codigo,
                                Precio = (double)dr.GetDecimal(dr.GetOrdinal("Precio")),
                                PrecioMinimo = (double)dr.GetDecimal(dr.GetOrdinal("PrecioMinimo")),
                                TipoISC = dr.GetString(dr.GetOrdinal("TipoISC")),
                                ISC = (double)dr.GetDecimal(dr.GetOrdinal("ISC")),
                                IGV = (double)dr.GetDecimal(dr.GetOrdinal("IGV")),
                                Exonerado = (double)dr.GetDecimal(dr.GetOrdinal("Exonerado")),
                                Stock = dr.GetInt16(dr.GetOrdinal("Stock")),
                                Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                CodigoLocal = new Local
                                {
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreLocal"))
                                },
                                CodigoProducto = new Producto
                                {
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreProducto"))
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

            return pre;
        }
    }
}