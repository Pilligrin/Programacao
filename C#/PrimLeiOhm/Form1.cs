using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimLeiOhm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static double corrente(double tensao, double resistencia)
        {
            return tensao / resistencia;
        }

        static double tensao(double corrente, double resistencia)
        {
            return corrente * resistencia;
        }
        
        static double resistencia(double tensao, double corrente)
        {
            return tensao / corrente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txb_tensao.Text != "") && (txb_resistencia.Text != "") && (txb_corrente.Text == ""))
            {
                double resultado = corrente(Convert.ToDouble(txb_tensao.Text), //converte para double
                         Double.Parse(txb_resistencia.Text)); //verifica se é double e converte
                lbl_resultado.Text = "Resultado: " + resultado.ToString() + " A";
            }

            if ((txb_tensao.Text == "") && (txb_resistencia.Text != "") && (txb_corrente.Text != ""))
            {

                double resultado = tensao(Convert.ToDouble(txb_corrente.Text), Convert.ToDouble(txb_resistencia.Text));
                lbl_resultado.Text = "Resultado: " + resultado.ToString() + " V";
            }

            if ((txb_tensao.Text != "") && (txb_resistencia.Text == "") && (txb_corrente.Text != ""))
            {
                double resultado = resistencia(Convert.ToDouble(txb_tensao.Text), Convert.ToDouble(txb_corrente.Text));
                lbl_resultado.Text = "Resultado: " + resultado.ToString() + " Ω";
            }
           
            
                   // lbl_resultado.Text = "Dados inseridos de modo incorreto!";

                        
               
               
           
        }
    }
}
