namespace TestesListas
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
            this.cbb_meses = new System.Windows.Forms.ComboBox();
            this.txb_valor = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_ler = new System.Windows.Forms.Button();
            this.cbb_faixa1 = new System.Windows.Forms.ComboBox();
            this.cbb_faixa2 = new System.Windows.Forms.ComboBox();
            this.cbb_faixa3 = new System.Windows.Forms.ComboBox();
            this.btn_calcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbb_meses
            // 
            this.cbb_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_meses.FormattingEnabled = true;
            this.cbb_meses.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbb_meses.Location = new System.Drawing.Point(260, 241);
            this.cbb_meses.Name = "cbb_meses";
            this.cbb_meses.Size = new System.Drawing.Size(324, 47);
            this.cbb_meses.TabIndex = 0;
            // 
            // txb_valor
            // 
            this.txb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor.Location = new System.Drawing.Point(313, 294);
            this.txb_valor.Name = "txb_valor";
            this.txb_valor.Size = new System.Drawing.Size(233, 47);
            this.txb_valor.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(295, 347);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(159, 72);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Adiciona";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ler
            // 
            this.btn_ler.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ler.Location = new System.Drawing.Point(475, 347);
            this.btn_ler.Name = "btn_ler";
            this.btn_ler.Size = new System.Drawing.Size(159, 72);
            this.btn_ler.TabIndex = 3;
            this.btn_ler.Text = "Testo";
            this.btn_ler.UseVisualStyleBackColor = true;
            this.btn_ler.Click += new System.EventHandler(this.btn_ler_Click);
            // 
            // cbb_faixa1
            // 
            this.cbb_faixa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_faixa1.FormattingEnabled = true;
            this.cbb_faixa1.Location = new System.Drawing.Point(67, 53);
            this.cbb_faixa1.Name = "cbb_faixa1";
            this.cbb_faixa1.Size = new System.Drawing.Size(192, 47);
            this.cbb_faixa1.TabIndex = 4;
            // 
            // cbb_faixa2
            // 
            this.cbb_faixa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_faixa2.FormattingEnabled = true;
            this.cbb_faixa2.Location = new System.Drawing.Point(282, 53);
            this.cbb_faixa2.Name = "cbb_faixa2";
            this.cbb_faixa2.Size = new System.Drawing.Size(192, 47);
            this.cbb_faixa2.TabIndex = 5;
            // 
            // cbb_faixa3
            // 
            this.cbb_faixa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_faixa3.FormattingEnabled = true;
            this.cbb_faixa3.Location = new System.Drawing.Point(502, 53);
            this.cbb_faixa3.Name = "cbb_faixa3";
            this.cbb_faixa3.Size = new System.Drawing.Size(192, 47);
            this.cbb_faixa3.TabIndex = 6;
            // 
            // btn_calcula
            // 
            this.btn_calcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcula.Location = new System.Drawing.Point(315, 138);
            this.btn_calcula.Name = "btn_calcula";
            this.btn_calcula.Size = new System.Drawing.Size(159, 72);
            this.btn_calcula.TabIndex = 7;
            this.btn_calcula.Text = "Calcula";
            this.btn_calcula.UseVisualStyleBackColor = true;
            this.btn_calcula.Click += new System.EventHandler(this.btn_calcula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcula);
            this.Controls.Add(this.cbb_faixa3);
            this.Controls.Add(this.cbb_faixa2);
            this.Controls.Add(this.cbb_faixa1);
            this.Controls.Add(this.btn_ler);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txb_valor);
            this.Controls.Add(this.cbb_meses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_meses;
        private System.Windows.Forms.TextBox txb_valor;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ler;
        private System.Windows.Forms.ComboBox cbb_faixa1;
        private System.Windows.Forms.ComboBox cbb_faixa2;
        private System.Windows.Forms.ComboBox cbb_faixa3;
        private System.Windows.Forms.Button btn_calcula;
    }
}

