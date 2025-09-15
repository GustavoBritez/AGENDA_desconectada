using BE;
using DAL;
using System;
using System.Collections.Generic;
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
    }
}
