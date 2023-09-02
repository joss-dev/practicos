namespace practico5
{
    partial class form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form5));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            btnFoto = new Button();
            label5 = new Label();
            DFecha = new DateTimePicker();
            RMujer = new RadioButton();
            RHombre = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TFoto = new TextBox();
            TSaldo = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            pictureBox2 = new PictureBox();
            DataGridPersonas = new DataGridView();
            openFile = new OpenFileDialog();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridPersonas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(-5, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(838, 560);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondopaneljpg;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(DFecha);
            panel1.Controls.Add(RMujer);
            panel1.Controls.Add(RHombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TFoto);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Location = new Point(86, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 322);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(156, 261);
            button1.Name = "button1";
            button1.Size = new Size(81, 48);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(66, 211);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(73, 23);
            btnFoto.TabIndex = 12;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(66, 167);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 11;
            label5.Text = "Saldo : ";
            // 
            // DFecha
            // 
            DFecha.Format = DateTimePickerFormat.Short;
            DFecha.Location = new Point(239, 97);
            DFecha.Name = "DFecha";
            DFecha.Size = new Size(84, 23);
            DFecha.TabIndex = 10;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.BackColor = Color.Transparent;
            RMujer.ForeColor = SystemColors.ButtonFace;
            RMujer.Location = new Point(214, 134);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(56, 19);
            RMujer.TabIndex = 9;
            RMujer.TabStop = true;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = false;
            // 
            // RHombre
            // 
            RHombre.AutoSize = true;
            RHombre.BackColor = Color.Transparent;
            RHombre.ForeColor = SystemColors.ButtonFace;
            RHombre.Location = new Point(136, 134);
            RHombre.Name = "RHombre";
            RHombre.Size = new Size(69, 19);
            RHombre.TabIndex = 8;
            RHombre.TabStop = true;
            RHombre.Text = "Hombre";
            RHombre.UseVisualStyleBackColor = false;
            RHombre.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(66, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 7;
            label4.Text = "Sexo : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(66, 97);
            label3.Name = "label3";
            label3.Size = new Size(176, 22);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Nacimiento : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(66, 51);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 5;
            label2.Text = "Apellido : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(66, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 4;
            label1.Text = "Nombre : ";
            // 
            // TFoto
            // 
            TFoto.Enabled = false;
            TFoto.Location = new Point(156, 212);
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(195, 23);
            TFoto.TabIndex = 3;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(156, 166);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(195, 23);
            TSaldo.TabIndex = 2;
            TSaldo.KeyPress += validacionSaldo;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(158, 53);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(193, 23);
            TApellido.TabIndex = 1;
            TApellido.TextChanged += mayusculaApellido;
            TApellido.KeyPress += validacionApellido;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(158, 14);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(195, 23);
            TNombre.TabIndex = 0;
            TNombre.TextChanged += mayusculaNombre;
            TNombre.KeyPress += validacionNombre;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.silueta;
            pictureBox2.Location = new Point(506, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // DataGridPersonas
            // 
            DataGridPersonas.AllowUserToAddRows = false;
            DataGridPersonas.AllowUserToOrderColumns = true;
            DataGridPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPersonas.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, FechaNacimiento, Sexo, BtnEliminar, Saldo, Foto, Ruta });
            DataGridPersonas.Location = new Point(-5, 399);
            DataGridPersonas.Name = "DataGridPersonas";
            DataGridPersonas.RowTemplate.Height = 25;
            DataGridPersonas.Size = new Size(838, 150);
            DataGridPersonas.TabIndex = 3;
            DataGridPersonas.CellContentClick += DataGridPersonas_CellContentClick;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.DataPropertyName = "Eliminar";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            BtnEliminar.DefaultCellStyle = dataGridViewCellStyle1;
            BtnEliminar.HeaderText = "Eliminar";
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Resizable = DataGridViewTriState.True;
            BtnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            BtnEliminar.Text = "Eliminar";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            Ruta.ReadOnly = true;
            // 
            // form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 561);
            Controls.Add(DataGridPersonas);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "form5";
            Text = "formulario dataGrid";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private RadioButton RHombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TFoto;
        private TextBox TSaldo;
        private TextBox TApellido;
        private TextBox TNombre;
        private RadioButton RMujer;
        private DateTimePicker DFecha;
        private Label label5;
        private Button btnFoto;
        private Button button1;
        private PictureBox pictureBox2;
        private DataGridView DataGridPersonas;
        private OpenFileDialog openFile;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn BtnEliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}