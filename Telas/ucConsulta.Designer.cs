namespace miaudota
{
    partial class ucConsulta
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
            this.tlpGatos = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpGatos
            // 
            this.tlpGatos.ColumnCount = 3;
            this.tlpGatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tlpGatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tlpGatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tlpGatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGatos.Location = new System.Drawing.Point(0, 0);
            this.tlpGatos.Name = "tlpGatos";
            this.tlpGatos.RowCount = 3;
            this.tlpGatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.30769F));
            this.tlpGatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46154F));
            this.tlpGatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
            this.tlpGatos.Size = new System.Drawing.Size(640, 650);
            this.tlpGatos.TabIndex = 0;
            // 
            // ucConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpGatos);
            this.Name = "ucConsulta";
            this.Size = new System.Drawing.Size(640, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGatos;
    }
}
