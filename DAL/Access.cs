using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    internal class Access
    {
        private SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=LOPO;Integrated Security=True;Trust Server Certificate=True");
        private SqlTransaction transaction;

        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }
        public void Start_TX()
        {
            this.transaction = conexion.BeginTransaction();
        }
        public void Stop_TX()
        {
            this.transaction.Rollback();
        }
        public void Commit_TX()
        {
            this.transaction.Commit();
        }

        public int Escribir( string query, SqlParameter[] sp)
        {
            try
            {
                Open();
                Start_TX();
                using ( SqlCommand cmd = new( query,conexion) )
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    if (sp != null)
                        cmd.Parameters.AddRange(sp);

                    cmd.Transaction = transaction;

                    int resultado = cmd.ExecuteNonQuery();
                    Commit_TX();

                    return resultado;
                }
            }
            catch
            {
                try
                {
                    Stop_TX();
                }
                catch
                {

                }
                return -1;
            }
            finally
            {
                Close();
            }
        }

        public DataTable Leer(string query, SqlParameter[] sp)
        {
            DataTable tabla_datos = new();
            try
            {
                Open();
                using ( SqlCommand cmd = new(query,conexion) )
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using( SqlDataAdapter adapter = new(cmd) )
                    {
                        adapter.Fill(tabla_datos);
                    }
                }
                return tabla_datos;
            }
            catch
            {
                return tabla_datos;
            }
            finally
            {
                Close();
            }
        }
    }
}
