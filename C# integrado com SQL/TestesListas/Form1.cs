using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //teste_array();
            //teste_lista_dinamica();
            List<string> faixas = new List<string>();
            faixas.Add("Preto");
            faixas.Add("Marrom");
            faixas.Add("Vermelho");
            faixas.Add("Laranja");
            faixas.Add("Amarelo");
            faixas.Add("Amarelo");
            faixas.Add("Verde");
            faixas.Add("Azul");
            faixas.Add("Violeta");
            faixas.Add("Cinza");
            faixas.Add("Branco");

            cbb_faixa1.Items.AddRange(faixas.ToArray());
            cbb_faixa2.Items.AddRange(faixas.ToArray());
            cbb_faixa3.Items.AddRange(faixas.ToArray());


        }
        void teste_array()
        {
            char[] teste = { 'M', 'R', 'z', 't', 'u', 'p', '5', '8' };
            MessageBox.Show(teste.Length.ToString());

            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(teste[i].ToString());
            }
            string[] meses = { "Janeiro", "Fevereiro", "Março","Abril", "Maio",
                               "Junho", "Julho", "Agosto", "Setembro", "Outubro",
                               "Novembro", "Dezembro" };
        }

        void teste_lista_dinamica()
        {
            List<string> nomes = new List<string>();
            //declara uma lista dinâmica de strings
            //new serve para falar que ainda não tenho os valores
            //o código fala que a lista de nomes, contendo variáveis do tipo string recebe uma lista sem valores ainda

            nomes.Add("Alexandre"); //adiciona  um novo elemento a coleção nomes
            nomes.Add("José");
            nomes.Add("Bruna");

            nomes.Sort();

            MessageBox.Show(nomes.Count.ToString());//contagem de elementos

            MessageBox.Show(nomes.Capacity.ToString());//o tamanho nele a memoria

            foreach(string nome in nomes) 
            {
                MessageBox.Show(nome); 
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //int confere = 0;
            //item é uma lista dinamica
            foreach(string mes in cbb_meses.Items)
            {
                if(mes == txb_valor.Text)
                {
                    //confere = 7; 
                    break;
                }
            }
            cbb_meses.Items.Add(txb_valor.Text);

        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            if(cbb_meses.SelectedItem == "Janeiro")
            {
                this.BackColor = Color.White;
            }

            else if(cbb_meses.SelectedIndex == 1)//testa se o mês seleciona é fevereiro
            {
                this.BackColor = Color.AliceBlue;
            }

            else if(cbb_meses.SelectedIndex == -1)
            {
                this.BackColor = Color.Green;
            }
        }

        private void btn_calcula_Click(object sender, EventArgs e)
            //esse método é utilizado para calcular o resistor depois de selecionada nas cores
        {
            if(cbb_faixa1.SelectedIndex != -1 && cbb_faixa2.SelectedIndex != -1 && cbb_faixa3.SelectedIndex != -1)
                //serve para somente calcular caso estejam todos com alguma cor selecionada
            {
                double valor = (cbb_faixa1.SelectedIndex * 10 + cbb_faixa2.SelectedIndex)
                 * Math.Pow(10, (cbb_faixa3.SelectedIndex));

                MessageBox.Show(valor.ToString());
            }


        }
    }
}
