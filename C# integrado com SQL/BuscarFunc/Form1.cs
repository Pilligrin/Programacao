using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscarFunc
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

        private void btn_atualiza_Click(object sender, EventArgs e)
        {
            //Realizar a conexão
            SqlConnection JUJUBA = new SqlConnection("Data source= HPFS-CE-LAB6904; Initial catalog= Silvio; User ID = sa;Password = 123456");
            //data source pode colocar "Data source= localhost;"

            //Realizar a consulta
            SqlDataAdapter nova_consulta = new SqlDataAdapter("SELECT func_id 'Código', func_nome 'Nome', * FROM funcionarios;", JUJUBA);

            //Manipular dados
            DataTable robin = new DataTable();
            nova_consulta.Fill(robin);//preenche o datatable  com as colunas e linhas da consulta realizada

            //Limpeza dos itens da List View ltv_funcionários, para não ficar com informação dobrada
            ltv_funcionarios.Items.Clear();//remove os itens anteriores
            ltv_funcionarios.Columns.Clear();

            //Adiciona o nome de cada coluna do ListView para ficar com o mesmo nome do DataTable robin

            ltv_funcionarios.Columns.Add(robin.Columns[0].ColumnName);
            ltv_funcionarios.Columns.Add(robin.Columns[1].ColumnName); 
            //ltv_funcionarios.Columns.Add(robin.Columns[2].ColumnName);
         

            //criar um novo item na coleção do listview
            foreach (DataRow elemento in robin.Rows) // para cada linha de dado chamada de elemento
            {
                ListViewItem novo_item = new ListViewItem(elemento[0].ToString());//declara um objeto de item para um ListView

                novo_item.SubItems.Add(elemento[1].ToString());//Adiciona o dado da coluna nome
                novo_item.SubItems.Add(elemento[2].ToString());//Adiciona o dado da coluna gerente
                novo_item.SubItems.Add(elemento[3].ToString());//Adiciona o dado da coluna setor
                novo_item.SubItems.Add(elemento[4].ToString());//Adiciona o dado da coluna salario
                novo_item.SubItems.Add(elemento[5].ToString());//Adiciona o dado da coluna data de nasc
          
                //inserir o novo item no listview
                ltv_funcionarios.Items.Add(novo_item); //adiciona o novo item a coleção do listview
            }

            //atribuir os subitens

            //inserir o novo item no listview


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conexão
            SqlConnection conecta = new SqlConnection("Data source = localhost; User ID = sa; Password = 123456; initial catalog = ExercicioDB");

            //consulta
            SqlDataAdapter consulta = new SqlDataAdapter("SELECT * FROM locacoes;", conecta); //consulta é o código SQL que você quer consultar, com a conexão no final
            //toda consulta é uma adaptação de dados do SQL

            //tabela da programação
            DataTable tabela_da_programacao = new DataTable();

            //preencher a tabela da programação
            consulta.Fill(tabela_da_programacao); // a consulta preenche a tabela da programação
        }
    }
}
