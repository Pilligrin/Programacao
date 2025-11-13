namespace GUI_Cenario_funcionarios
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Item 3");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpb_lista = new System.Windows.Forms.GroupBox();
            this.ltv_funcionarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_atualiza = new System.Windows.Forms.Button();
            this.gpb_cadastro = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_func_nome = new System.Windows.Forms.TextBox();
            this.cbb_func_gerente = new System.Windows.Forms.ComboBox();
            this.cbb_func_setor = new System.Windows.Forms.ComboBox();
            this.txb_func_salario = new System.Windows.Forms.TextBox();
            this.txb_func_datanasc = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpb_lista.SuspendLayout();
            this.gpb_cadastro.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gpb_lista, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_atualiza, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gpb_cadastro, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gpb_lista
            // 
            this.gpb_lista.Controls.Add(this.ltv_funcionarios);
            this.gpb_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_lista.Location = new System.Drawing.Point(3, 105);
            this.gpb_lista.Name = "gpb_lista";
            this.gpb_lista.Size = new System.Drawing.Size(578, 221);
            this.gpb_lista.TabIndex = 0;
            this.gpb_lista.TabStop = false;
            this.gpb_lista.Text = "Lista de funcionários";
            // 
            // ltv_funcionarios
            // 
            this.ltv_funcionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ltv_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltv_funcionarios.HideSelection = false;
            this.ltv_funcionarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.ltv_funcionarios.Location = new System.Drawing.Point(3, 27);
            this.ltv_funcionarios.Name = "ltv_funcionarios";
            this.ltv_funcionarios.Size = new System.Drawing.Size(572, 191);
            this.ltv_funcionarios.TabIndex = 0;
            this.ltv_funcionarios.UseCompatibleStateImageBehavior = false;
            this.ltv_funcionarios.View = System.Windows.Forms.View.Details;
            // 
            // btn_atualiza
            // 
            this.btn_atualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualiza.Location = new System.Drawing.Point(3, 332);
            this.btn_atualiza.Name = "btn_atualiza";
            this.btn_atualiza.Size = new System.Drawing.Size(435, 37);
            this.btn_atualiza.TabIndex = 1;
            this.btn_atualiza.Text = "Atualizar lista";
            this.btn_atualiza.UseVisualStyleBackColor = true;
            this.btn_atualiza.Click += new System.EventHandler(this.btn_atualiza_Click);
            // 
            // gpb_cadastro
            // 
            this.gpb_cadastro.Controls.Add(this.tableLayoutPanel2);
            this.gpb_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_cadastro.Location = new System.Drawing.Point(3, 382);
            this.gpb_cadastro.Name = "gpb_cadastro";
            this.gpb_cadastro.Size = new System.Drawing.Size(578, 223);
            this.gpb_cadastro.TabIndex = 2;
            this.gpb_cadastro.TabStop = false;
            this.gpb_cadastro.Text = "Cadastrar novo funcionário";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txb_func_nome, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbb_func_gerente, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbb_func_setor, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txb_func_salario, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txb_func_datanasc, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_gravar, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(572, 193);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gerente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de nasc.";
            // 
            // txb_func_nome
            // 
            this.txb_func_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_func_nome.Location = new System.Drawing.Point(193, 3);
            this.txb_func_nome.Name = "txb_func_nome";
            this.txb_func_nome.Size = new System.Drawing.Size(184, 31);
            this.txb_func_nome.TabIndex = 5;
            // 
            // cbb_func_gerente
            // 
            this.cbb_func_gerente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_func_gerente.FormattingEnabled = true;
            this.cbb_func_gerente.Location = new System.Drawing.Point(193, 41);
            this.cbb_func_gerente.Name = "cbb_func_gerente";
            this.cbb_func_gerente.Size = new System.Drawing.Size(184, 33);
            this.cbb_func_gerente.TabIndex = 6;
            this.cbb_func_gerente.DropDown += new System.EventHandler(this.cbb_func_gerente_DropDown);
            // 
            // cbb_func_setor
            // 
            this.cbb_func_setor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_func_setor.FormattingEnabled = true;
            this.cbb_func_setor.Location = new System.Drawing.Point(193, 79);
            this.cbb_func_setor.Name = "cbb_func_setor";
            this.cbb_func_setor.Size = new System.Drawing.Size(184, 33);
            this.cbb_func_setor.TabIndex = 7;
            this.cbb_func_setor.DropDown += new System.EventHandler(this.cbb_func_setor_DropDown);
            // 
            // txb_func_salario
            // 
            this.txb_func_salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_func_salario.Location = new System.Drawing.Point(193, 117);
            this.txb_func_salario.Name = "txb_func_salario";
            this.txb_func_salario.Size = new System.Drawing.Size(184, 31);
            this.txb_func_salario.TabIndex = 8;
            // 
            // txb_func_datanasc
            // 
            this.txb_func_datanasc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_func_datanasc.Location = new System.Drawing.Point(193, 155);
            this.txb_func_datanasc.Name = "txb_func_datanasc";
            this.txb_func_datanasc.Size = new System.Drawing.Size(184, 31);
            this.txb_func_datanasc.TabIndex = 9;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gravar.Location = new System.Drawing.Point(383, 41);
            this.btn_gravar.Name = "btn_gravar";
            this.tableLayoutPanel2.SetRowSpan(this.btn_gravar, 3);
            this.btn_gravar.Size = new System.Drawing.Size(186, 108);
            this.btn_gravar.TabIndex = 10;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gpb_lista.ResumeLayout(false);
            this.gpb_cadastro.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gpb_lista;
        private System.Windows.Forms.ListView ltv_funcionarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_atualiza;
        private System.Windows.Forms.GroupBox gpb_cadastro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_func_nome;
        private System.Windows.Forms.ComboBox cbb_func_gerente;
        private System.Windows.Forms.ComboBox cbb_func_setor;
        private System.Windows.Forms.TextBox txb_func_salario;
        private System.Windows.Forms.TextBox txb_func_datanasc;
        private System.Windows.Forms.Button btn_gravar;
    }
}

