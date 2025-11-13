using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPotencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbb_W.Checked == true)
                {
                    double tensao = double.Parse(txb_tensao.Text);
                    double corrente = double.Parse(txb_corrente.Text);
                    double pot = tensao * corrente;

                    string texto = string.Format("Resultado: {0} W", pot);
                    lbl_resultado_pot.Text = texto;
                }
                else //ou if(rbb_kW.Checked == true)
                {
                    double tensao = double.Parse(txb_tensao.Text);
                    double corrente = double.Parse(txb_corrente.Text);
                    double pot_k = (tensao * corrente) / 1000;

                    string texto = string.Format("Resultado: {0} kW", pot_k);
                    lbl_resultado_pot.Text = texto;
                }
            }
            catch 
            {
                lbl_resultado_pot.Text = "Por favor, digite um número válido.";
                MessageBox.Show("Erro!");
            }
        }

        private void lbl_corrente_Click(object sender, EventArgs e)
        {

        }
    }
}
