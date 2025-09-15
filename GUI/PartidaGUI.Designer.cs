namespace GUI
{
    partial class PartidaGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GoupBox = new GroupBox();
            OP_3 = new CheckBox();
            OP_2 = new CheckBox();
            OP_1 = new CheckBox();
            Rich_Tx = new RichTextBox();
            BTN_VOLVER_ATRAS = new Button();
            BTN_ENVIAR_RESPUESTA = new Button();
            BTN_Agregar_Bloque = new Button();
            GoupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GoupBox
            // 
            GoupBox.Controls.Add(OP_3);
            GoupBox.Controls.Add(OP_2);
            GoupBox.Controls.Add(OP_1);
            GoupBox.Controls.Add(Rich_Tx);
            GoupBox.FlatStyle = FlatStyle.System;
            GoupBox.Location = new Point(69, 58);
            GoupBox.Name = "GoupBox";
            GoupBox.Size = new Size(586, 188);
            GoupBox.TabIndex = 0;
            GoupBox.TabStop = false;
            GoupBox.Text = "Trivia";
            // 
            // OP_3
            // 
            OP_3.AutoSize = true;
            OP_3.Location = new Point(32, 163);
            OP_3.Name = "OP_3";
            OP_3.Size = new Size(83, 19);
            OP_3.TabIndex = 3;
            OP_3.Text = "checkBox3";
            OP_3.UseVisualStyleBackColor = true;
            // 
            // OP_2
            // 
            OP_2.AutoSize = true;
            OP_2.Location = new Point(32, 127);
            OP_2.Name = "OP_2";
            OP_2.Size = new Size(83, 19);
            OP_2.TabIndex = 2;
            OP_2.Text = "checkBox2";
            OP_2.UseVisualStyleBackColor = true;
            // 
            // OP_1
            // 
            OP_1.AutoSize = true;
            OP_1.Location = new Point(32, 87);
            OP_1.Name = "OP_1";
            OP_1.Size = new Size(83, 19);
            OP_1.TabIndex = 1;
            OP_1.Text = "checkBox1";
            OP_1.UseVisualStyleBackColor = true;
            // 
            // Rich_Tx
            // 
            Rich_Tx.Location = new Point(6, 22);
            Rich_Tx.Name = "Rich_Tx";
            Rich_Tx.Size = new Size(574, 59);
            Rich_Tx.TabIndex = 0;
            Rich_Tx.Text = "";
            // 
            // BTN_VOLVER_ATRAS
            // 
            BTN_VOLVER_ATRAS.Location = new Point(75, 275);
            BTN_VOLVER_ATRAS.Name = "BTN_VOLVER_ATRAS";
            BTN_VOLVER_ATRAS.Size = new Size(158, 44);
            BTN_VOLVER_ATRAS.TabIndex = 1;
            BTN_VOLVER_ATRAS.Text = "Volver Atras";
            BTN_VOLVER_ATRAS.UseVisualStyleBackColor = true;
            // 
            // BTN_ENVIAR_RESPUESTA
            // 
            BTN_ENVIAR_RESPUESTA.Location = new Point(499, 275);
            BTN_ENVIAR_RESPUESTA.Name = "BTN_ENVIAR_RESPUESTA";
            BTN_ENVIAR_RESPUESTA.Size = new Size(156, 44);
            BTN_ENVIAR_RESPUESTA.TabIndex = 2;
            BTN_ENVIAR_RESPUESTA.Text = "Enviar Respuesta";
            BTN_ENVIAR_RESPUESTA.UseVisualStyleBackColor = true;
            // 
            // BTN_Agregar_Bloque
            // 
            BTN_Agregar_Bloque.Location = new Point(281, 12);
            BTN_Agregar_Bloque.Name = "BTN_Agregar_Bloque";
            BTN_Agregar_Bloque.Size = new Size(156, 44);
            BTN_Agregar_Bloque.TabIndex = 3;
            BTN_Agregar_Bloque.Text = "Agregar Bloque";
            BTN_Agregar_Bloque.UseVisualStyleBackColor = true;
            BTN_Agregar_Bloque.Click += BTN_Agregar_Bloque_Click;
            // 
            // PartidaGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 366);
            Controls.Add(BTN_Agregar_Bloque);
            Controls.Add(BTN_ENVIAR_RESPUESTA);
            Controls.Add(BTN_VOLVER_ATRAS);
            Controls.Add(GoupBox);
            Name = "PartidaGUI";
            Text = "PartidaGUI";
            GoupBox.ResumeLayout(false);
            GoupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GoupBox;
        private RichTextBox Rich_Tx;
        private Button BTN_VOLVER_ATRAS;
        private Button BTN_ENVIAR_RESPUESTA;
        private CheckBox OP_3;
        private CheckBox OP_2;
        private CheckBox OP_1;
        private Button BTN_Agregar_Bloque;
    }
}