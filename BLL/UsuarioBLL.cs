using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL mapper = new();
        public void Agregar_Usuario(UsuarioBE newU )
        {
            if (newU is null)
                throw new ArgumentNullException();
            try
            {
                mapper.Agregar_Usuario(newU);
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void Eliminar_Usuario( string id_usuario )
        {
            if (string.IsNullOrEmpty(id_usuario))
                throw new ArgumentNullException();
            try
            {
                mapper.Eliminar_Usuario(id_usuario);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public List<UsuarioBE> Obtener_Usuarios() => mapper.Obtener_Usuarios();
    }
}
