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

namespace GUI_Cenario_funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_atualiza_Click(object sender, EventArgs e)
        {
            //Realizar a conexão
            SqlConnection jujuba = new SqlConnection("Data source= localhost; Initial catalog= Silvio; User ID= sa; Password= 123456");
            //Realizar a consulta
            SqlDataAdapter nova_consulta = new SqlDataAdapter( "SELECT func_id 'Código', func_nome 'Nome', * FROM funcionarios;",jujuba) ;
            //Manipular os dados
            DataTable robin = new DataTable();
            nova_consulta.Fill( robin ); //Preenche o datatable com as colunas e linhas da consulta realizada

            ltv_funcionarios.Items.Clear();//Remove os itens anteriores
            ltv_funcionarios.Columns.Clear();
            ltv_funcionarios.Columns.Add(robin.Columns[0].ColumnName);
            ltv_funcionarios.Columns.Add(robin.Columns[1].ColumnName);
            //ltv_funcionarios.Columns[0].Text = robin.Columns[0].ColumnName;//


            //Criar um novo item na coleção do listview
            foreach (DataRow elemento in robin.Rows)
            {
                ListViewItem novo_item = new ListViewItem(elemento[0].ToString());//Declara um objeto de item para um listview
                novo_item.SubItems.Add(elemento[1].ToString()); //Adiciona o dado da coluna nome
                novo_item.SubItems.Add(elemento[2].ToString()); //Adiciona o dado da coluna gerente id
                novo_item.SubItems.Add(elemento[3].ToString()); //Adiciona o dado da coluna setor id
                novo_item.SubItems.Add(elemento[4].ToString()); //Adiciona o dado da coluna salario
                novo_item.SubItems.Add(elemento[5].ToString()); //Adiciona o dado da coluna data de nasc
                //Inserir o novo item no listview
                ltv_funcionarios.Items.Add(novo_item); //Adiciona o novo item à coleção do listview
            }

            //Atribuir os subitens

            
            
        }

        private void cbb_func_gerente_DropDown(object sender, EventArgs e)
        {
            //REaliza a conexão
            SqlConnection surto = new SqlConnection("Data source= localhost;Initial catalog= Silvio; User ID= sa; Password= 123456");
            //Realiza a consulta
            SqlDataAdapter consulta = new SqlDataAdapter("SELECT func_id, func_nome FROM funcionarios;", surto);
            //Atribui o resultado
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            //Vincula os valores do combobox com a tabela da consulta
            cbb_func_gerente.DataSource = resultado;
            cbb_func_gerente.DisplayMember = "func_nome"; //Mostra o nome do funcionário
            cbb_func_gerente.ValueMember = "func_id"; //Valor do ID do funcionário selecionado
        }

        private void cbb_func_setor_DropDown(object sender, EventArgs e)
        {
            //REaliza a conexão
            SqlConnection surto = new SqlConnection("Data source= localhost;Initial catalog= Silvio; User ID= sa; Password= 123456");
            //Realiza a consulta
            SqlDataAdapter consulta = new SqlDataAdapter("SELECT setor_id, setor_nome FROM setores;", surto);
            //Atribui o resultado
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            //Vincula os valores do combobox com a tabela da consulta
            cbb_func_setor.DataSource = resultado;
            cbb_func_setor.DisplayMember = "setor_nome"; //Mostra o nome do setor
            cbb_func_setor.ValueMember = "setor_id"; //Valor do ID do setor selecionado

        }
    }
}
