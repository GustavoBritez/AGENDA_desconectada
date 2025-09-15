using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BloqueBE
    {
        private int nro_bloque;
        private string enunciado;
        private string respuesta1;
        private string respuesta2;
        private string respuesta3;
        private string correcta;

        public int NroBloque {  get { return nro_bloque; } set { nro_bloque = value; } }
        public string Enunciado { get { return enunciado; } set { enunciado = value; } }
        public string Respuesta1 { get { return respuesta1; } set { respuesta1 = value; } }
        public string Respuesta2 { get { return respuesta2; } set { respuesta2 = value; } }
        public string Respuesta3 { get { return respuesta3; } set { respuesta3 = value; } }
        public string Correcta { get { return correcta; } set { correcta = value; } }

    }
}
