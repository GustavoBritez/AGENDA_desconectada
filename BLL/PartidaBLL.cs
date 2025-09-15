using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PartidaBLL
    {
        PartidaDAL mapper = new PartidaDAL();
        
        public void Agregar_Bloque(BloqueBE newBloque)
        {
            try
            {

                PartidaBE partidaBE = new PartidaBE();

            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public DataTable Obtener_Bloque( )
        {
            try
            {
                return mapper.ObtenerBloques();
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
