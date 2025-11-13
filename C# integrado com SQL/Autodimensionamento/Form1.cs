using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autodimensionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close(); //Encerra o Form1
        }

        private void btn_calc_circ_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_titulo.Text = string.Format("A área do círculo é de {0:F2}u²", Math.Pow(Double.Parse(txb_raio_circ.Text), 2) * Math.PI);
            }
            catch
            {
                MessageBox.Show("O número digitado não é válido!");
            }
            
        }
    }
}
