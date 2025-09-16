namespace GUI
{
    partial class UsuarioGUI
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
            Grilla_Usuarios = new DataGridView();
            label1 = new Label();
            BTN_Agregar = new Button();
            BTN_Eliminar = new Button();
            BTN_Jugar = new Button();
            ((System.ComponentModel.ISupportInitialize)Grilla_Usuarios).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Usuarios
            // 
            Grilla_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Usuarios.Location = new Point(99, 40);
            Grilla_Usuarios.Name = "Grilla_Usuarios";
            Grilla_Usuarios.Size = new Size(415, 108);
            Grilla_Usuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.Location = new Point(99, 167);
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.Size = new Size(75, 23);
            BTN_Agregar.TabIndex = 2;
            BTN_Agregar.Text = "Agregar";
            BTN_Agregar.UseVisualStyleBackColor = true;
            BTN_Agregar.Click += BTN_Agregar_Click;
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.Location = new Point(439, 167);
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.Size = new Size(75, 23);
            BTN_Eliminar.TabIndex = 3;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.UseVisualStyleBackColor = true;
            BTN_Eliminar.Click += BTN_Eliminar_Click;
            // 
            // BTN_Jugar
            // 
            BTN_Jugar.Location = new Point(267, 224);
            BTN_Jugar.Name = "BTN_Jugar";
            BTN_Jugar.Size = new Size(75, 23);
            BTN_Jugar.TabIndex = 4;
            BTN_Jugar.Text = "Jugar";
            BTN_Jugar.UseVisualStyleBackColor = true;
            BTN_Jugar.Click += BTN_Jugar_Click;
            // 
            // UsuarioGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 274);
            Controls.Add(BTN_Jugar);
            Controls.Add(BTN_Eliminar);
            Controls.Add(BTN_Agregar);
            Controls.Add(label1);
            Controls.Add(Grilla_Usuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsuarioGUI";
            Text = "UsuarioGUI";
            Load += UsuarioGUI_Load;
            ((System.ComponentModel.ISupportInitialize)Grilla_Usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Usuarios;
        private Label label1;
        private Button BTN_Agregar;
        private Button BTN_Eliminar;
        private Button BTN_Jugar;
    }
}