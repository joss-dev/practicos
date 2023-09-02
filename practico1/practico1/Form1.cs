namespace practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            TApellidoYnombre.Text = TApellido.Text + " " + TNombre.Text;
        }
        private void BEliminar_Click(object sender, EventArgs e)
        {
            TApellidoYnombre.Clear();
        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salir(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void salir(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}