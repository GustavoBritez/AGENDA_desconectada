using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.VisualBasic;
using BE;

namespace GUI
{
    public partial class UsuarioGUI : Form
    {
        public UsuarioGUI()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            UsuarioBLL logica_Usuario = new();
            Grilla_Usuarios.DataSource = null;
            Grilla_Usuarios.DataSource = logica_Usuario.Obtener_Usuarios();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL logica_Usuario = new UsuarioBLL();

                string nombre = Interaction.InputBox("Ingresar Nombre");
                int telefono = Convert.ToInt32(Interaction.InputBox("Ingresar Telefono"));

                UsuarioBE newUsuario = new UsuarioBE
                {
                    Nombre = nombre,
                    Telefono = telefono
                };

                logica_Usuario.Agregar_Usuario(newUsuario);
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Usuarios.Rows.Count < 0) throw new ArgumentException("Seleccione una fila");

                string id_usuario = Grilla_Usuarios.Rows[0].Cells["Id_Usuario"].Value.ToString();

                UsuarioBLL logica_Usuario = new();

                logica_Usuario.Eliminar_Usuario(id_usuario);

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Jugar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Usuarios.Rows.Count < 0) throw new ArgumentException();

                int id_usuario = Convert.ToInt32(Grilla_Usuarios.Rows[0].Cells["Id_Usuario"].Value.ToString());

                this.Hide();
                PartidaGUI form = new(id_usuario);

                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsuarioGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
