namespace CalculadoraPotencia
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_tensao = new System.Windows.Forms.Label();
            this.lbl_corrente = new System.Windows.Forms.Label();
            this.lbl_resultado_pot = new System.Windows.Forms.Label();
            this.rbb_W = new System.Windows.Forms.RadioButton();
            this.txb_tensao = new System.Windows.Forms.TextBox();
            this.txb_corrente = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.rbb_kW = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.rbb_kW, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txb_corrente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_resultado_pot, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_corrente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_titulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_tensao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txb_tensao, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbb_W, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_cal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_titulo, 3);
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_titulo.Location = new System.Drawing.Point(3, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(910, 84);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Calculadora de Potência";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // Lbl_tensao
            // 
            this.Lbl_tensao.AutoSize = true;
            this.Lbl_tensao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_tensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tensao.Location = new System.Drawing.Point(3, 84);
            this.Lbl_tensao.Name = "Lbl_tensao";
            this.Lbl_tensao.Size = new System.Drawing.Size(299, 84);
            this.Lbl_tensao.TabIndex = 1;
            this.Lbl_tensao.Text = "Tensão:";
            this.Lbl_tensao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_tensao.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_corrente
            // 
            this.lbl_corrente.AutoSize = true;
            this.lbl_corrente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_corrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corrente.Location = new System.Drawing.Point(3, 168);
            this.lbl_corrente.Name = "lbl_corrente";
            this.lbl_corrente.Size = new System.Drawing.Size(299, 84);
            this.lbl_corrente.TabIndex = 4;
            this.lbl_corrente.Text = "Corrente:";
            this.lbl_corrente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_corrente.Click += new System.EventHandler(this.lbl_corrente_Click);
            // 
            // lbl_resultado_pot
            // 
            this.lbl_resultado_pot.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_resultado_pot, 3);
            this.lbl_resultado_pot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_resultado_pot.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado_pot.Location = new System.Drawing.Point(3, 336);
            this.lbl_resultado_pot.Name = "lbl_resultado_pot";
            this.lbl_resultado_pot.Size = new System.Drawing.Size(910, 84);
            this.lbl_resultado_pot.TabIndex = 10;
            this.lbl_resultado_pot.Text = "Resultado:";
            this.lbl_resultado_pot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbb_W
            // 
            this.rbb_W.AutoSize = true;
            this.rbb_W.Checked = true;
            this.rbb_W.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbb_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbb_W.Location = new System.Drawing.Point(3, 255);
            this.rbb_W.Name = "rbb_W";
            this.rbb_W.Size = new System.Drawing.Size(299, 78);
            this.rbb_W.TabIndex = 11;
            this.rbb_W.TabStop = true;
            this.rbb_W.Text = "Watt";
            this.rbb_W.UseVisualStyleBackColor = true;
            // 
            // txb_tensao
            // 
            this.txb_tensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tensao.Location = new System.Drawing.Point(308, 87);
            this.txb_tensao.Multiline = true;
            this.txb_tensao.Name = "txb_tensao";
            this.txb_tensao.Size = new System.Drawing.Size(299, 78);
            this.txb_tensao.TabIndex = 12;
            // 
            // txb_corrente
            // 
            this.txb_corrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_corrente.Location = new System.Drawing.Point(308, 171);
            this.txb_corrente.Multiline = true;
            this.txb_corrente.Name = "txb_corrente";
            this.txb_corrente.Size = new System.Drawing.Size(299, 78);
            this.txb_corrente.TabIndex = 13;
            // 
            // btn_cal
            // 
            this.btn_cal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.Location = new System.Drawing.Point(613, 87);
            this.btn_cal.Name = "btn_cal";
            this.tableLayoutPanel1.SetRowSpan(this.btn_cal, 2);
            this.btn_cal.Size = new System.Drawing.Size(300, 162);
            this.btn_cal.TabIndex = 14;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbb_kW
            // 
            this.rbb_kW.AutoSize = true;
            this.rbb_kW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbb_kW.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbb_kW.Location = new System.Drawing.Point(308, 255);
            this.rbb_kW.Name = "rbb_kW";
            this.rbb_kW.Size = new System.Drawing.Size(299, 78);
            this.rbb_kW.TabIndex = 15;
            this.rbb_kW.Text = "kilo-Watt";
            this.rbb_kW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Energia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label Lbl_tensao;
        private System.Windows.Forms.Label lbl_resultado_pot;
        private System.Windows.Forms.Label lbl_corrente;
        private System.Windows.Forms.TextBox txb_corrente;
        private System.Windows.Forms.TextBox txb_tensao;
        private System.Windows.Forms.RadioButton rbb_W;
        private System.Windows.Forms.RadioButton rbb_kW;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

