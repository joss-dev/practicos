namespace practico4y5
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            label2 = new Label();
            TDesde = new TextBox();
            THasta = new TextBox();
            btnGenerarFuncion = new Button();
            ListBoxNumeros = new ListBox();
            label3 = new Label();
            btnNumerosPares = new Button();
            btnNumerosImpares = new Button();
            btnNumerosPrimos = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 84);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 137);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Hasta";
            // 
            // TDesde
            // 
            TDesde.Location = new Point(140, 81);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(129, 23);
            TDesde.TabIndex = 7;
            TDesde.TextChanged += TDesde_TextChanged;
            TDesde.KeyPress += validacionDesde;
            // 
            // THasta
            // 
            THasta.Location = new Point(140, 134);
            THasta.Name = "THasta";
            THasta.Size = new Size(129, 23);
            THasta.TabIndex = 8;
            THasta.KeyPress += validacionHasta;
            // 
            // btnGenerarFuncion
            // 
            btnGenerarFuncion.Location = new Point(67, 190);
            btnGenerarFuncion.Name = "btnGenerarFuncion";
            btnGenerarFuncion.Size = new Size(109, 23);
            btnGenerarFuncion.TabIndex = 9;
            btnGenerarFuncion.Text = "Generar Funcion";
            btnGenerarFuncion.UseVisualStyleBackColor = true;
            btnGenerarFuncion.Click += btnGenerarFuncion_Click;
            // 
            // ListBoxNumeros
            // 
            ListBoxNumeros.FormattingEnabled = true;
            ListBoxNumeros.ItemHeight = 15;
            ListBoxNumeros.Location = new Point(227, 190);
            ListBoxNumeros.Name = "ListBoxNumeros";
            ListBoxNumeros.Size = new Size(259, 229);
            ListBoxNumeros.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 20);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 11;
            label3.Text = "Lista de numeros";
            // 
            // btnNumerosPares
            // 
            btnNumerosPares.Location = new Point(67, 238);
            btnNumerosPares.Name = "btnNumerosPares";
            btnNumerosPares.Size = new Size(109, 23);
            btnNumerosPares.TabIndex = 12;
            btnNumerosPares.Text = "Numeros Pares";
            btnNumerosPares.UseVisualStyleBackColor = true;
            btnNumerosPares.Click += btnNumerosPares_Click;
            // 
            // btnNumerosImpares
            // 
            btnNumerosImpares.Location = new Point(67, 287);
            btnNumerosImpares.Name = "btnNumerosImpares";
            btnNumerosImpares.Size = new Size(109, 23);
            btnNumerosImpares.TabIndex = 13;
            btnNumerosImpares.Text = "Numeros Impares";
            btnNumerosImpares.UseVisualStyleBackColor = true;
            btnNumerosImpares.Click += btnNumerosImpares_Click;
            // 
            // btnNumerosPrimos
            // 
            btnNumerosPrimos.Location = new Point(67, 341);
            btnNumerosPrimos.Name = "btnNumerosPrimos";
            btnNumerosPrimos.Size = new Size(109, 23);
            btnNumerosPrimos.TabIndex = 14;
            btnNumerosPrimos.Text = "Numeros Primos";
            btnNumerosPrimos.UseVisualStyleBackColor = true;
            btnNumerosPrimos.Click += btnNumerosPrimos_Click;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Silver;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(533, 119);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 15;
            chart1.Text = "Números";
            chart1.Click += chart1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 623);
            Controls.Add(chart1);
            Controls.Add(btnNumerosPrimos);
            Controls.Add(btnNumerosImpares);
            Controls.Add(btnNumerosPares);
            Controls.Add(label3);
            Controls.Add(ListBoxNumeros);
            Controls.Add(btnGenerarFuncion);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Formulario 4";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TDesde;
        private TextBox THasta;
        private Button btnGenerarFuncion;
        private ListBox ListBoxNumeros;
        private Label label3;
        private Button btnNumerosPares;
        private Button btnNumerosImpares;
        private Button btnNumerosPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}