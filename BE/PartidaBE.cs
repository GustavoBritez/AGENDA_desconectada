using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PartidaBE
    {
        private int id_partida;
        private List<BloqueBE> lista_Bloques;

        public int Id_Partida { get { return id_partida; } set { id_partida = value; }}
        public void Agregar ( BloqueBE newBloque )
        {
            try
            {
                this.lista_Bloques.Add( newBloque );    
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void Eliminar(BloqueBE newBloque = null, int nro_bloque = 0 )
        {
            if (newBloque is null && nro_bloque is 0)
                throw new ArgumentException(" No hay anda que eliminar");
            try
            {
                if (nro_bloque != 0)
                    this.lista_Bloques.RemoveAt(nro_bloque);
                if ( newBloque is not null )
                    this.lista_Bloques.Remove(newBloque);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
