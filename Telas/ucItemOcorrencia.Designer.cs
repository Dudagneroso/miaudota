namespace miaudota.Telas
{
    partial class ucItemOcorrencia
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSigla = new System.Windows.Forms.Label();
            this.pnlConteudoOcorrencia = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblLocalResponsavel = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pnlConteudoOcorrencia.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSigla
            // 
            this.lblSigla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.lblSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.lblSigla.Location = new System.Drawing.Point(13, 12);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(32, 32);
            this.lblSigla.TabIndex = 4;
            this.lblSigla.Text = "DV";
            this.lblSigla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlConteudoOcorrencia
            // 
            this.pnlConteudoOcorrencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConteudoOcorrencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.pnlConteudoOcorrencia.Controls.Add(this.pnlConteudo);
            this.pnlConteudoOcorrencia.Location = new System.Drawing.Point(65, 8);
            this.pnlConteudoOcorrencia.Name = "pnlConteudoOcorrencia";
            this.pnlConteudoOcorrencia.Padding = new System.Windows.Forms.Padding(1);
            this.pnlConteudoOcorrencia.Size = new System.Drawing.Size(353, 119);
            this.pnlConteudoOcorrencia.TabIndex = 5;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.lblData);
            this.pnlConteudo.Controls.Add(this.lblDescricao);
            this.pnlConteudo.Controls.Add(this.lblLocalResponsavel);
            this.pnlConteudo.Controls.Add(this.lblTipo);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(1, 1);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(351, 117);
            this.pnlConteudo.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.lblData.Location = new System.Drawing.Point(258, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(75, 13);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "20/09/2026";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.lblDescricao.Location = new System.Drawing.Point(19, 81);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(159, 17);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Gato devolvido pelo tutor";
            // 
            // lblLocalResponsavel
            // 
            this.lblLocalResponsavel.AutoSize = true;
            this.lblLocalResponsavel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalResponsavel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.lblLocalResponsavel.Location = new System.Drawing.Point(20, 49);
            this.lblLocalResponsavel.Name = "lblLocalResponsavel";
            this.lblLocalResponsavel.Size = new System.Drawing.Size(229, 13);
            this.lblLocalResponsavel.TabIndex = 7;
            this.lblLocalResponsavel.Text = "Projeto Mundo Felino . Registrador por Ana";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.lblTipo.Location = new System.Drawing.Point(19, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 20);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Devolução";
            // 
            // ucItemOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConteudoOcorrencia);
            this.Controls.Add(this.lblSigla);
            this.Name = "ucItemOcorrencia";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(426, 135);
            this.pnlConteudoOcorrencia.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Panel pnlConteudoOcorrencia;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Label lblLocalResponsavel;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDescricao;
    }
}
