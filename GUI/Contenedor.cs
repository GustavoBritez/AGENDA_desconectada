using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();

        }

        public void Cambiar_Ventana(Form ventana)
        {
            Panel_Contenedor.Controls.Clear();

            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;

            Panel_Contenedor.Controls.Add(ventana);
            ventana.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cambiar_Ventana(new UsuarioGUI());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
