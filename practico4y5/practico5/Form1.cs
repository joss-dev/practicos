using practico5.Properties;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace practico5
{
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TFoto.Text) || string.IsNullOrWhiteSpace(TSaldo.Text)) && !(RHombre.Checked || RMujer.Checked))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string rutaImagen = TFoto.Text; // La ruta de la imagen desde el TextBox
                pictureBox2.Image = Image.FromFile(rutaImagen);
                Image imagen = Image.FromFile(rutaImagen);
                decimal saldo = Convert.ToDecimal(TSaldo.Text);
                string sexo;
                if (RHombre.Checked)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }
                int index = DataGridPersonas.Rows.Add(TApellido.Text, TNombre.Text, DFecha.Text, sexo, "Eliminar", TSaldo.Text, imagen, TFoto.Text);

                if (saldo < 50)
                {
                    DataGridPersonas.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    DataGridPersonas.Rows[index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void DataGridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna del botón "Eliminar"
            if (e.ColumnIndex == DataGridPersonas.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                MsgBoxResult result = (MsgBoxResult)MessageBox.Show("Estas a punto de eliminar un registro", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (result == MsgBoxResult.Yes)
                {
                    pictureBox2.Image = Resources.silueta;
                    // Eliminar la fila

                    DataGridPersonas.Rows.RemoveAt(e.RowIndex);
                }

            }
            if (e.ColumnIndex == DataGridPersonas.Columns["Sexo"].Index && e.RowIndex >= 0)
            {
                if ("Hombre" == DataGridPersonas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    RMujer.Checked = false;
                    RHombre.Checked = true;
                }else
                {
                    RHombre.Checked = false;
                    RMujer.Checked = true;
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string rutaFoto = openFile.FileName;
                TFoto.Text = rutaFoto;

            }
        }

        private void mayusculaNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text) && char.IsLower(textBox.Text[0]))
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final del texto
            }
        }

        private void mayusculaApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text) && char.IsLower(textBox.Text[0]))
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final del texto
            }
        }

        private void validacionSaldo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validacionNombre(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }

        private void validacionApellido(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }


    }
}