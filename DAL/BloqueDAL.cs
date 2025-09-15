using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BloqueDAL
    {
        Access acceso = new();

        public void Agregar_Bloque( BloqueBE newBloque )
        {
            if (newBloque is null)
                throw new ArgumentException("Bloque no puede ser null");
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@ENUNCIADO", System.Data.SqlDbType.NVarChar) { Value = newBloque.Enunciado },
                    new SqlParameter("@RESPUESTA1", System.Data.SqlDbType.NVarChar) { Value = newBloque.Respuesta1 },
                    new SqlParameter("@RESPUESTA2", System.Data.SqlDbType.NVarChar) { Value = newBloque.Respuesta2 },
                    new SqlParameter("@RESPUESTA3", System.Data.SqlDbType.NVarChar) { Value = newBloque.Respuesta3 },
                    new SqlParameter("@CORRECTA", System.Data.SqlDbType.NVarChar) { Value = newBloque.Correcta },
                };

                acceso.Escribir("AGREGAR_BLOQUE", sp);

            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Eliminar_Bloque(BloqueBE newBloque)
        {
            if (newBloque is null)
                throw new ArgumentException("Bloque no puede ser null");
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@NRO_BLOQUE", System.Data.SqlDbType.NVarChar) { Value = newBloque.NroBloque },

                };

                acceso.Escribir("ELIMINAR_BLOQUE", sp);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
