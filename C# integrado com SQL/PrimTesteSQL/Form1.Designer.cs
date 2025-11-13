namespace PrimTesteSQL
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.cbb_usuarios = new System.Windows.Forms.ComboBox();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(357, 12);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(170, 56);
            this.btn_consulta.TabIndex = 0;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(5, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(109, 39);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "label1";
            // 
            // cbb_usuarios
            // 
            this.cbb_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_usuarios.FormattingEnabled = true;
            this.cbb_usuarios.Location = new System.Drawing.Point(12, 80);
            this.cbb_usuarios.Name = "cbb_usuarios";
            this.cbb_usuarios.Size = new System.Drawing.Size(339, 50);
            this.cbb_usuarios.TabIndex = 2;
            // 
            // btn_preencher
            // 
            this.btn_preencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preencher.Location = new System.Drawing.Point(357, 74);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(208, 56);
            this.btn_preencher.TabIndex = 3;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 354);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.cbb_usuarios);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_consulta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.ComboBox cbb_usuarios;
        private System.Windows.Forms.Button btn_preencher;
    }
}

