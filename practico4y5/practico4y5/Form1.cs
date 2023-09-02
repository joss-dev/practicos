using System.Windows.Forms.DataVisualization.Charting;
namespace practico4y5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarFuncion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxNumeros.Items.Clear();
                for (int i = int.Parse(TDesde.Text); i <= int.Parse(THasta.Text); i++)
                {
                    ListBoxNumeros.Items.Add(i.ToString());
                }
            }

            chart1_Click(chart1, EventArgs.Empty);

        }

        private void validacionDesde(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validacionHasta(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNumerosPares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxNumeros.Items.Clear();
                for (int i = int.Parse(TDesde.Text); i <= int.Parse(THasta.Text); i++)
                {
                    if (i % 2 == 0)
                    {
                        ListBoxNumeros.Items.Add(i.ToString());
                    }
                }
            }
            chart1_Click(chart1, EventArgs.Empty);

        }

        private void btnNumerosImpares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxNumeros.Items.Clear();
                for (int i = int.Parse(TDesde.Text); i <= int.Parse(THasta.Text); i++)
                {
                    if (!(i % 2 == 0))
                    {
                        ListBoxNumeros.Items.Add(i.ToString());
                    }
                }
            }
            chart1_Click(chart1, EventArgs.Empty);

        }

        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxNumeros.Items.Clear();
                for (int i = int.Parse(TDesde.Text); i <= int.Parse(THasta.Text); i++)
                {
                    bool esPrimo = true;

                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo && i > 1)
                    {
                        ListBoxNumeros.Items.Add(i.ToString());
                    }
                }
            }
            chart1_Click(chart1, EventArgs.Empty);
        }

        private void TDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Obtener el gráfico que se hizo clic
            var chart = (Chart)sender;

            // Limpiar los datos del gráfico
            chart.Series[0].Points.Clear();

            // Agregar datos de ListBoxNumeros al gráfico
            for (int i = 0; i < ListBoxNumeros.Items.Count; i++)
            {
                chart.Series[0].Points.AddXY(i + 1, int.Parse(ListBoxNumeros.Items[i].ToString()));
            }
        }
    }
}