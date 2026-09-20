namespace miaudota.Telas
{
    partial class ucConsultaGatos1
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
            this.lblTituloConsultaGatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloConsultaGatos
            // 
            this.lblTituloConsultaGatos.AutoSize = true;
            this.lblTituloConsultaGatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultaGatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloConsultaGatos.Location = new System.Drawing.Point(21, 18);
            this.lblTituloConsultaGatos.Name = "lblTituloConsultaGatos";
            this.lblTituloConsultaGatos.Size = new System.Drawing.Size(159, 20);
            this.lblTituloConsultaGatos.TabIndex = 2;
            this.lblTituloConsultaGatos.Text = "Consulta de Gatos";
            // 
            // ucConsultaGatos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTituloConsultaGatos);
            this.Name = "ucConsultaGatos1";
            this.Size = new System.Drawing.Size(598, 645);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloConsultaGatos;
    }
}
