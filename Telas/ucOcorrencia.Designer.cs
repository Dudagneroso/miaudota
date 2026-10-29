namespace miaudota.Telas
{
    partial class ucOcorrencia
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
            this.lblCadastroTutor = new System.Windows.Forms.Label();
            this.lblTituloRegistroOcorrencia = new System.Windows.Forms.Label();
            this.pnlSelecaoGato = new System.Windows.Forms.Panel();
            this.pnlTipoOcorrência = new System.Windows.Forms.Panel();
            this.pnlDetalhesOcorrência = new System.Windows.Forms.Panel();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.pnlSelecaoGato.SuspendLayout();
            this.pnlTipoOcorrência.SuspendLayout();
            this.pnlDetalhesOcorrência.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroTutor
            // 
            this.lblCadastroTutor.Location = new System.Drawing.Point(24, 50);
            this.lblCadastroTutor.Name = "lblCadastroTutor";
            this.lblCadastroTutor.Size = new System.Drawing.Size(399, 13);
            this.lblCadastroTutor.TabIndex = 31;
            this.lblCadastroTutor.Text = "Mantenha o histórico e a situação de cada gato sempre atualizados";
            // 
            // lblTituloRegistroOcorrencia
            // 
            this.lblTituloRegistroOcorrencia.AutoSize = true;
            this.lblTituloRegistroOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistroOcorrencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloRegistroOcorrencia.Location = new System.Drawing.Point(23, 21);
            this.lblTituloRegistroOcorrencia.Name = "lblTituloRegistroOcorrencia";
            this.lblTituloRegistroOcorrencia.Size = new System.Drawing.Size(175, 20);
            this.lblTituloRegistroOcorrencia.TabIndex = 30;
            this.lblTituloRegistroOcorrencia.Text = "Registrar Ocorrência";
            // 
            // pnlSelecaoGato
            // 
            this.pnlSelecaoGato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSelecaoGato.Controls.Add(this.lblSelecao);
            this.pnlSelecaoGato.Location = new System.Drawing.Point(27, 90);
            this.pnlSelecaoGato.Name = "pnlSelecaoGato";
            this.pnlSelecaoGato.Size = new System.Drawing.Size(560, 116);
            this.pnlSelecaoGato.TabIndex = 32;
            // 
            // pnlTipoOcorrência
            // 
            this.pnlTipoOcorrência.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTipoOcorrência.Controls.Add(this.lblTipo);
            this.pnlTipoOcorrência.Location = new System.Drawing.Point(27, 221);
            this.pnlTipoOcorrência.Name = "pnlTipoOcorrência";
            this.pnlTipoOcorrência.Size = new System.Drawing.Size(560, 213);
            this.pnlTipoOcorrência.TabIndex = 33;
            // 
            // pnlDetalhesOcorrência
            // 
            this.pnlDetalhesOcorrência.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDetalhesOcorrência.Controls.Add(this.lblDetalhes);
            this.pnlDetalhesOcorrência.Location = new System.Drawing.Point(27, 450);
            this.pnlDetalhesOcorrência.Name = "pnlDetalhesOcorrência";
            this.pnlDetalhesOcorrência.Size = new System.Drawing.Size(560, 273);
            this.pnlDetalhesOcorrência.TabIndex = 34;
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblSelecao.Location = new System.Drawing.Point(19, 14);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(123, 13);
            this.lblSelecao.TabIndex = 34;
            this.lblSelecao.Text = "1. SELECIONE O GATO";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblTipo.Location = new System.Drawing.Point(19, 13);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(136, 13);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "2. TIPO DE OCORRÊNCIA";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblDetalhes.Location = new System.Drawing.Point(19, 18);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(168, 13);
            this.lblDetalhes.TabIndex = 34;
            this.lblDetalhes.Text = "3. DETALHES DA OCORRÊNCIA";
            // 
            // ucOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDetalhesOcorrência);
            this.Controls.Add(this.pnlTipoOcorrência);
            this.Controls.Add(this.pnlSelecaoGato);
            this.Controls.Add(this.lblCadastroTutor);
            this.Controls.Add(this.lblTituloRegistroOcorrencia);
            this.Name = "ucOcorrencia";
            this.Size = new System.Drawing.Size(640, 804);
            this.pnlSelecaoGato.ResumeLayout(false);
            this.pnlSelecaoGato.PerformLayout();
            this.pnlTipoOcorrência.ResumeLayout(false);
            this.pnlTipoOcorrência.PerformLayout();
            this.pnlDetalhesOcorrência.ResumeLayout(false);
            this.pnlDetalhesOcorrência.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroTutor;
        private System.Windows.Forms.Label lblTituloRegistroOcorrencia;
        private System.Windows.Forms.Panel pnlSelecaoGato;
        private System.Windows.Forms.Panel pnlTipoOcorrência;
        private System.Windows.Forms.Panel pnlDetalhesOcorrência;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDetalhes;
    }
}
