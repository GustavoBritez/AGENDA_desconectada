using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class UsuarioDAL
    {
        private Access acceso = new();

        public void Agregar_Usuario( UsuarioBE newU )
        {
            if ( newU is null )
                throw new NullReferenceException();
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@NOMBRE",System.Data.SqlDbType.NVarChar) { Value = newU.Nombre},
                    new SqlParameter("@TELEFONO",System.Data.SqlDbType.NVarChar) { Value = newU.Telefono}
                };

                acceso.Escribir( "AGREGAR_USUARIO", sp );
            }
            catch( Exception ex )
            {
                throw;
            }
        }

        public void Eliminar_Usuario( string id_usuario)
        {
            if (string.IsNullOrEmpty(id_usuario))
                throw new ArgumentNullException();
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@ID_USUARIO",System.Data.SqlDbType.NVarChar) { Value = id_usuario }
                };

                acceso.Escribir("ELIMINAR_USUARIO", sp);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<UsuarioBE> Obtener_Usuarios()
        {
            try
            {
                List<UsuarioBE> lista_usuarios = new();
                DataTable datos_obtenidos = acceso.Leer("OBTENER_USUARIOS", null);

                foreach( DataRow datos in datos_obtenidos.Rows)
                {
                    UsuarioBE agregar = new UsuarioBE
                    {
                        Id_Usuario = Convert.ToInt32(datos["ID_USUARIO"]),
                        Nombre = Convert.ToString(datos["NOMBRE"]),
                        Telefono = Convert.ToInt32(datos["TELEFONO"])
                    };
                    lista_usuarios.Add(agregar);
                }
                return lista_usuarios;
            }
            catch
            {
                throw;
            }
        }
    }
}
