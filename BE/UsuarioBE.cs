using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioBE
    {
        private int id_usuario;
        private string nombre;
        private int telefono;

        public int Id_Usuario { get => id_usuario; set { id_usuario = value; } }
        public string Nombre { get => nombre; set { nombre = value; } }
        public int Telefono { get => telefono; set { telefono = value; } }
    }
}
