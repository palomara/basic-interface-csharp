using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);

            double soma = value1 + value2;

            lblResultado.Text = soma.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);

            double subtracao = value1 - value2;

            lblResultado.Text = subtracao.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);

            double mult = value1 * value2;

            lblResultado.Text = mult.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);

            double div = value1 / value2;

            lblResultado.Text = div.ToString();
        }



        
    }
}
