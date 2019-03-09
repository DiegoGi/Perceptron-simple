using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace PerceptronSimple
{
    public partial class form1 : Form
    {
        private ValoresEntrada valores;

        public form1()
        {
            valores = new ValoresEntrada();
            InitializeComponent();

        }

        private void Compuerta_CheckedChanged(object sender, EventArgs e)
        {
            dGValores.Rows.Clear();
            if (rbtnAnd.Checked)
            {
                dGValores.Rows.Add("0", "0", "0");
                dGValores.Rows.Add("0", "1", "0");
                dGValores.Rows.Add("1", "0", "0");
                dGValores.Rows.Add("1", "1", "1");
            }
            else if (rbtnOr.Checked)
            {
                dGValores.Rows.Add("0", "0", "0");
                dGValores.Rows.Add("0", "1", "1");
                dGValores.Rows.Add("1", "0", "1");
                dGValores.Rows.Add("1", "1", "1");
            }
            else
            {
                dGValores.Rows.Add("2", "0", "1");
                dGValores.Rows.Add("0", "0", "-1");
                dGValores.Rows.Add("2", "2", "1");
                dGValores.Rows.Add("0", "1", "-1");
                dGValores.Rows.Add("1", "1", "1");
                dGValores.Rows.Add("1", "2", "-1");

                //dGValores.Rows.Add("0", "2", "0");
                //dGValores.Rows.Add("1", "0", "0");
                //dGValores.Rows.Add("2", "1", "0");


            }

            List<double> x1 = new List<double>();
            List<double> x2 = new List<double>();
            List<double> dx = new List<double>();

            foreach (DataGridViewRow row in dGValores.Rows)
            {
                x1.Add(double.Parse(row.Cells[0].Value.ToString()));
                x2.Add(double.Parse(row.Cells[1].Value.ToString()));
                dx.Add(double.Parse(row.Cells[2].Value.ToString()));
            }

            valores.X1 = x1.ToArray();
            valores.X2 = x2.ToArray();
            valores.Dx = dx.ToArray();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtEntradaW1.Text.Length > 0 &&
                txtEntradaW2.Text.Length > 0 &&
                txtEntradaEpocas.Text.Length > 0 &&
              txtEntradaFactor.Text.Length > 0 &&
              txtEntradaUmbral.Text.Length > 0)
            {

                try
                {
                    valores.W1 = Double.Parse(txtEntradaW1.Text, CultureInfo.InvariantCulture);
                    valores.W2 = Double.Parse(txtEntradaW2.Text, CultureInfo.InvariantCulture);
                    valores.Epocas = Convert.ToInt32(txtEntradaEpocas.Text);
                    valores.Umbral = Double.Parse(txtEntradaUmbral.Text, CultureInfo.InvariantCulture);
                    valores.Factor = Double.Parse(txtEntradaFactor.Text, CultureInfo.InvariantCulture);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valores no validos.",
             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CompuertasLogicas compuertas = new CompuertasLogicas(valores);
                ValoresSalida valoresSalida = compuertas.CalcularValores();
                txtSalidaW1.Text = valoresSalida.W1.ToString();
                txtSalidaW2.Text = valoresSalida.W2.ToString();
                
                txtEpocasNecesarias.Text = valoresSalida.Epocas.ToString();

            }
            else
            {
                MessageBox.Show("Ingrese todos los campos necesarios.",
             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntradaW1.Clear();
            txtEntradaW2.Clear();
            txtEntradaFactor.Clear();
            txtEntradaEpocas.Clear();
            txtEntradaUmbral.Clear();

            txtSalidaW1.Clear();
            txtSalidaW2.Clear();
           
            txtEpocasNecesarias.Clear();
        }
    }
}
