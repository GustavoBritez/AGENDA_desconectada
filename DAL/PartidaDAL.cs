using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartidaDAL
    {
        Access acceso = new();

        public DataTable ObtenerBloques()
        {
            try
            {
                DataTable bloques = acceso.Leer("OBTENERBLOQUES", null);

                return bloques;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
