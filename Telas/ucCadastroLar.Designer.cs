namespace miaudota.Telas
{
    partial class ucCadastroLar
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
            this.lblCadastarLar = new System.Windows.Forms.Label();
            this.lblDescricaoLar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCadastarLar
            // 
            this.lblCadastarLar.AutoSize = true;
            this.lblCadastarLar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastarLar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCadastarLar.Location = new System.Drawing.Point(21, 9);
            this.lblCadastarLar.Name = "lblCadastarLar";
            this.lblCadastarLar.Size = new System.Drawing.Size(214, 20);
            this.lblCadastarLar.TabIndex = 0;
            this.lblCadastarLar.Text = "Cadastrar Lar Temporário";
            // 
            // lblDescricaoLar
            // 
            this.lblDescricaoLar.AutoSize = true;
            this.lblDescricaoLar.Location = new System.Drawing.Point(22, 38);
            this.lblDescricaoLar.Name = "lblDescricaoLar";
            this.lblDescricaoLar.Size = new System.Drawing.Size(297, 13);
            this.lblDescricaoLar.TabIndex = 1;
            this.lblDescricaoLar.Text = "Registre uma família parceira para acolhimento temporário‍ 👨‍👩‍👧‍👦 ";
            // 
            // ucCadastroLar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDescricaoLar);
            this.Controls.Add(this.lblCadastarLar);
            this.Name = "ucCadastroLar";
            this.Size = new System.Drawing.Size(710, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastarLar;
        private System.Windows.Forms.Label lblDescricaoLar;
    }
}
