namespace practico1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BGuardar = new Button();
            BEliminar = new Button();
            LNombre = new Label();
            LApellido = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TApellidoYnombre = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.Lime;
            BGuardar.FlatStyle = FlatStyle.Popup;
            BGuardar.Location = new Point(51, 164);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.BackColor = Color.Red;
            BEliminar.FlatStyle = FlatStyle.Popup;
            BEliminar.Location = new Point(154, 164);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(51, 72);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(51, 112);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            LApellido.Click += LApellido_Click;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(108, 69);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 4;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(108, 112);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 5;
            // 
            // TApellidoYnombre
            // 
            TApellidoYnombre.Location = new Point(284, 69);
            TApellidoYnombre.Multiline = true;
            TApellidoYnombre.Name = "TApellidoYnombre";
            TApellidoYnombre.Size = new Size(154, 118);
            TApellidoYnombre.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.IndianRed;
            BSalir.FlatAppearance.BorderColor = Color.Red;
            BSalir.FlatStyle = FlatStyle.Popup;
            BSalir.Location = new Point(391, 222);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(TApellidoYnombre);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LNombre;
        private Label LApellido;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TApellidoYnombre;
        private Button BSalir;
    }
}