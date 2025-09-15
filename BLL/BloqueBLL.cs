using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BLL
{
    public class BloqueBLL
    {
        BloqueDAL mapper = new();

        public void Crear_Bloque( BloqueBE newBloque )
        {
            try
            {
                mapper.Agregar_Bloque(newBloque);
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
