namespace PrimLeiOhm
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
            this.lbl_tensao = new System.Windows.Forms.Label();
            this.txb_tensao = new System.Windows.Forms.TextBox();
            this.txb_resistencia = new System.Windows.Forms.TextBox();
            this.lbl_resistencia = new System.Windows.Forms.Label();
            this.txb_corrente = new System.Windows.Forms.TextBox();
            this.lbl_corrente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tensao
            // 
            this.lbl_tensao.AutoSize = true;
            this.lbl_tensao.CausesValidation = false;
            this.lbl_tensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensao.Location = new System.Drawing.Point(58, 126);
            this.lbl_tensao.Name = "lbl_tensao";
            this.lbl_tensao.Size = new System.Drawing.Size(120, 31);
            this.lbl_tensao.TabIndex = 0;
            this.lbl_tensao.Text = "Tensão:";
            this.lbl_tensao.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_tensao
            // 
            this.txb_tensao.CausesValidation = false;
            this.txb_tensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tensao.Location = new System.Drawing.Point(229, 129);
            this.txb_tensao.Name = "txb_tensao";
            this.txb_tensao.Size = new System.Drawing.Size(140, 31);
            this.txb_tensao.TabIndex = 1;
            this.txb_tensao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_resistencia
            // 
            this.txb_resistencia.CausesValidation = false;
            this.txb_resistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_resistencia.Location = new System.Drawing.Point(229, 182);
            this.txb_resistencia.Name = "txb_resistencia";
            this.txb_resistencia.Size = new System.Drawing.Size(140, 31);
            this.txb_resistencia.TabIndex = 3;
            // 
            // lbl_resistencia
            // 
            this.lbl_resistencia.AutoSize = true;
            this.lbl_resistencia.CausesValidation = false;
            this.lbl_resistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resistencia.Location = new System.Drawing.Point(58, 179);
            this.lbl_resistencia.Name = "lbl_resistencia";
            this.lbl_resistencia.Size = new System.Drawing.Size(176, 31);
            this.lbl_resistencia.TabIndex = 2;
            this.lbl_resistencia.Text = "Resistência:";
            // 
            // txb_corrente
            // 
            this.txb_corrente.CausesValidation = false;
            this.txb_corrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_corrente.Location = new System.Drawing.Point(229, 241);
            this.txb_corrente.Name = "txb_corrente";
            this.txb_corrente.Size = new System.Drawing.Size(140, 31);
            this.txb_corrente.TabIndex = 5;
            // 
            // lbl_corrente
            // 
            this.lbl_corrente.AutoSize = true;
            this.lbl_corrente.CausesValidation = false;
            this.lbl_corrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corrente.Location = new System.Drawing.Point(58, 238);
            this.lbl_corrente.Name = "lbl_corrente";
            this.lbl_corrente.Size = new System.Drawing.Size(137, 31);
            this.lbl_corrente.TabIndex = 4;
            this.lbl_corrente.Text = "Corrente:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 143);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.CausesValidation = false;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(58, 299);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(201, 31);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Resultado: XX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(865, 509);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_corrente);
            this.Controls.Add(this.lbl_corrente);
            this.Controls.Add(this.txb_resistencia);
            this.Controls.Add(this.lbl_resistencia);
            this.Controls.Add(this.txb_tensao);
            this.Controls.Add(this.lbl_tensao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tensao;
        private System.Windows.Forms.TextBox txb_tensao;
        private System.Windows.Forms.TextBox txb_resistencia;
        private System.Windows.Forms.Label lbl_resistencia;
        private System.Windows.Forms.TextBox txb_corrente;
        private System.Windows.Forms.Label lbl_corrente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

