using BE;
using BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class PartidaGUI : Form
    {
        int Idusuario;
        PartidaBE newPartida = new();

        public PartidaGUI(int id_usuario)
        {
            Idusuario = id_usuario;
            InitializeComponent();
        }

        private void BTN_Agregar_Bloque_Click(object sender, EventArgs e)
        {
            try
            {
                BloqueBE newBloque = new();

                newBloque.Enunciado = Interaction.InputBox(" Ingrese Enunciado");
                newBloque.Respuesta1 = Interaction.InputBox(" Ingrese opcion 1");
                newBloque.Respuesta2 = Interaction.InputBox(" Ingrese opcion 2");
                newBloque.Respuesta3 = Interaction.InputBox(" Ingrese opcion 3");
                newBloque.Correcta = Interaction.InputBox(" Ingrese opcion Correcta");

                BloqueBLL logica_Bloque = new();

                if (
                    string.IsNullOrEmpty(newBloque.Enunciado) ||
                    string.IsNullOrEmpty(newBloque.Respuesta1) ||
                    string.IsNullOrEmpty(newBloque.Respuesta2) ||
                    string.IsNullOrEmpty(newBloque.Respuesta3) ||
                    string.IsNullOrEmpty(newBloque.Correcta))
                    throw new ArgumentException("No deben quedar opciones vacias");

                logica_Bloque.Crear_Bloque(newBloque);

            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Crear_Partida()
        {
            try
            {
                PartidaBLL logica_Partida = new();

                DataTable Bloques_Cargados = logica_Partida.Obtener_Bloque() ;

                Random aleatorio = new Random();

                int contador = 0;

                int index = aleatorio.Next(Bloques_Cargados.Rows.Count);

                string enunciado = Bloques_Cargados.Rows[index]["ENUNCIADO"].ToString();

                Rich_Tx.Clear();
                Rich_Tx.AppendText(enunciado);

                foreach( CheckBox CB in GB_BOX.Controls )
                {
                    CB.Text = string.Empty;
                }

                OP_1.Text = Bloques_Cargados.Rows[index]["RESPUESTA1"].ToString();
                OP_2.Text = Bloques_Cargados.Rows[index]["RESPUESTA2"].ToString();
                OP_3.Text = Bloques_Cargados.Rows[index]["RESPUESTA3"].ToString();
                string respuestaCorrecta = Bloques_Cargados.Rows[index]["CORRECTA"].ToString();

                BTN_ENVIAR_RESPUESTA.Click += (alo, send) =>
                {
                    if (string.Equals(OP_1.Text, respuestaCorrecta , StringComparison.OrdinalIgnoreCase))
                    {
                        contador += 1;
                    }
                    if (string.Equals(OP_2.Text, respuestaCorrecta, StringComparison.OrdinalIgnoreCase))
                    {
                        contador += 1;
                    }
                    if (string.Equals(OP_3.Text, respuestaCorrecta, StringComparison.OrdinalIgnoreCase))
                    {
                        contador += 1;
                    }
                };

            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
