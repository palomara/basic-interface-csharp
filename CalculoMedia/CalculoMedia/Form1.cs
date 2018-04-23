using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txb1Bim.Text);
            double value2 = System.Convert.ToDouble(txb2Bim.Text);
            double value3 = System.Convert.ToDouble(txb3Bim.Text);
            double value4 = System.Convert.ToDouble(txb4Bim.Text);

            double media = (value1 + value2 + value3 + value4) / 4;

            string name = txbNome.Text;

            lblNome.Text = name;

            lblMedia.Text = "Sua média é: " + media.ToString();
        }
       
    }
}
