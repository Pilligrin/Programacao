namespace Autodimensionamento
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
            this.gpb_planos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gpb_volumes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_raio_circ = new System.Windows.Forms.TextBox();
            this.btn_calc_circ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_lado_quad = new System.Windows.Forms.TextBox();
            this.btn_calc_quad = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpb_planos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_titulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpb_planos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gpb_volumes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_fechar, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_titulo, 3);
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(3, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(717, 150);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Calculadora geométrica";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpb_planos
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gpb_planos, 3);
            this.gpb_planos.Controls.Add(this.tableLayoutPanel2);
            this.gpb_planos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_planos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_planos.Location = new System.Drawing.Point(3, 153);
            this.gpb_planos.Name = "gpb_planos";
            this.gpb_planos.Size = new System.Drawing.Size(717, 144);
            this.gpb_planos.TabIndex = 1;
            this.gpb_planos.TabStop = false;
            this.gpb_planos.Text = "Cálculo de áreas de geometrias planas";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.btn_calc_quad, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txb_lado_quad, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txb_raio_circ, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_calc_circ, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 116);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gpb_volumes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gpb_volumes, 3);
            this.gpb_volumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_volumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_volumes.Location = new System.Drawing.Point(3, 303);
            this.gpb_volumes.Name = "gpb_volumes";
            this.gpb_volumes.Size = new System.Drawing.Size(717, 144);
            this.gpb_volumes.TabIndex = 2;
            this.gpb_volumes.TabStop = false;
            this.gpb_volumes.Text = "Cálculo de volumes de formas geométricas básicas";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do raio do círculo";
            // 
            // txb_raio_circ
            // 
            this.txb_raio_circ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_raio_circ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_raio_circ.Location = new System.Drawing.Point(416, 14);
            this.txb_raio_circ.Name = "txb_raio_circ";
            this.txb_raio_circ.Size = new System.Drawing.Size(171, 29);
            this.txb_raio_circ.TabIndex = 1;
            // 
            // btn_calc_circ
            // 
            this.btn_calc_circ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calc_circ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_circ.Location = new System.Drawing.Point(593, 3);
            this.btn_calc_circ.Name = "btn_calc_circ";
            this.btn_calc_circ.Size = new System.Drawing.Size(115, 52);
            this.btn_calc_circ.TabIndex = 2;
            this.btn_calc_circ.Text = "Calcular";
            this.btn_calc_circ.UseVisualStyleBackColor = true;
            this.btn_calc_circ.Click += new System.EventHandler(this.btn_calc_circ_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o valor do lado do quadrado";
            // 
            // txb_lado_quad
            // 
            this.txb_lado_quad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_lado_quad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_lado_quad.Location = new System.Drawing.Point(416, 72);
            this.txb_lado_quad.Name = "txb_lado_quad";
            this.txb_lado_quad.Size = new System.Drawing.Size(171, 29);
            this.txb_lado_quad.TabIndex = 4;
            // 
            // btn_calc_quad
            // 
            this.btn_calc_quad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calc_quad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_quad.Location = new System.Drawing.Point(593, 61);
            this.btn_calc_quad.Name = "btn_calc_quad";
            this.btn_calc_quad.Size = new System.Drawing.Size(115, 52);
            this.btn_calc_quad.TabIndex = 5;
            this.btn_calc_quad.Text = "Calcular";
            this.btn_calc_quad.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(599, 467);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(121, 32);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gpb_planos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox gpb_planos;
        private System.Windows.Forms.GroupBox gpb_volumes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_raio_circ;
        private System.Windows.Forms.Button btn_calc_circ;
        private System.Windows.Forms.Button btn_calc_quad;
        private System.Windows.Forms.TextBox txb_lado_quad;
        private System.Windows.Forms.Button btn_fechar;
    }
}

