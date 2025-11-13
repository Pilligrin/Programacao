using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // namespace (biblioteca) que contém os objetos de manipulação do banco de dados
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimTesteSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1° - Conectar-se
            SqlConnection conexao = new SqlConnection("Data source= HPFS-CE-LAB6904;User ID = sa;Password= 123456;Initial catalog= AdventureWorks2019");

            //2° - Consultar
            //string instrucao1 = "SELECT FirstName FROM Person.Person WHERE BusinessEntityID = 3;";
            //string instrucao2 = "SELECT FirstName, LastName FROM Person.Person WHERE BusinessEntityID = 3;";
            string instrucao3 = "SELECT FirstName + '' + LastName FROM Person.Person WHERE BusinessEntityID = 3;";
            SqlDataAdapter consulta = new SqlDataAdapter(instrucao3, conexao);
            DataTable fernando = new DataTable();//declara um novo objeto do tipo datatable vazio
            consulta.Fill(fernando);//Atribui os dados da consulta para o DataTable fernando

            //3° - Atribuir o nome ao trexto do lbl_nome
            lbl_nome.Text = fernando.Rows[0][0].ToString();
            //lbl_nome.Text = string.Format("{0} {1}", fernando.Rows[0][0], fernando.Rows[0][1]); //para instrução 2
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            SqlConnection connessione= new SqlConnection("Data source= HPFS-CE-LAB6904;User ID = sa;Password= 123456;Initial catalog= AdventureWorks2019");

            SqlDataAdapter dados = new SqlDataAdapter("SELECT BusinessEntityID, FirstName FROM Person.Person;", connessione);
            DataTable tabela = new DataTable();
            dados.Fill(tabela);

            cbb_usuarios.DataSource = tabela;//atribui todas as linhas e colunas da consulta para o combobox
            cbb_usuarios.DisplayMember = "FirstName"; //configura para que o texto aparente seja o nome dos usuários
            //exibe no combobox a coluna de nome FirstName

            cbb_usuarios.ValueMember = "BusinessEntityID";//configura para que o valor selecionado seja o ID do usuário
            //o valor de retorno não vai ser o mesmo que o exibido, vai retornar o ID
        }
    }
}
