using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DAL : IDisposable
    {

        private IDbConnection conexion;
        private IDbTransaction transaccion;

        public DAL()
        {

        }

        public DAL(string api, string cadenaConexion, bool transaccion = false)
        {
            this.Conectar(api, cadenaConexion, transaccion);
        }

        public void Conectar(string api, string cadenaConexion, bool transaccion = false)
        {
            DbProviderFactory fabrica = DbProviderFactories.GetFactory(api);

            this.conexion = fabrica.CreateConnection();
            this.conexion.ConnectionString = cadenaConexion;
            this.conexion.Open();
            if (transaccion == true)
            {
                this.transaccion = this.conexion.BeginTransaction();
            }
        }

        public void Cerrar(bool modo)
        {
            if (this.transaccion != null)
            {
                if (modo == true)
                {
                    this.transaccion.Commit();
                }
                else
                {
                    this.transaccion.Rollback();
                }
            }
        }

        public IDataReader EjecutarOrden(string sql, bool devolverDatos = false)
        {
            IDataReader dr = null;

            try
            {
                using (IDbCommand cmd = this.conexion.CreateCommand())
                {
                    if (this.transaccion != null)
                    {
                        cmd.Transaction = this.transaccion;
                    }
                    cmd.CommandText = sql;
                    if (devolverDatos == false)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        dr = cmd.ExecuteReader();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dr;
        }

        public void Dispose()
        {
            if (this.conexion != null)
            {
                if (this.transaccion != null)
                {
                    this.transaccion.Dispose();
                }

                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
                this.conexion.Dispose();
            }
        }

    }
}
