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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblFiltrarGato = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.cbFiltroGatos = new System.Windows.Forms.ComboBox();
            this.lblTituloConsultaGatos = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvarTutor = new System.Windows.Forms.Button();
            this.pnlFiltros.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.btnSalvarTutor);
            this.pnlFiltros.Controls.Add(this.lblFiltrarGato);
            this.pnlFiltros.Controls.Add(this.textBox1);
            this.pnlFiltros.Controls.Add(this.lblPesquisar);
            this.pnlFiltros.Controls.Add(this.cbFiltroGatos);
            this.pnlFiltros.Controls.Add(this.lblTituloConsultaGatos);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(634, 111);
            this.pnlFiltros.TabIndex = 0;
            // 
            // lblFiltrarGato
            // 
            this.lblFiltrarGato.AutoSize = true;
            this.lblFiltrarGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarGato.Location = new System.Drawing.Point(347, 17);
            this.lblFiltrarGato.Name = "lblFiltrarGato";
            this.lblFiltrarGato.Size = new System.Drawing.Size(62, 15);
            this.lblFiltrarGato.TabIndex = 7;
            this.lblFiltrarGato.Text = "Filtrar por:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 25);
            this.textBox1.TabIndex = 6;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(24, 75);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(65, 15);
            this.lblPesquisar.TabIndex = 5;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // cbFiltroGatos
            // 
            this.cbFiltroGatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroGatos.FormattingEnabled = true;
            this.cbFiltroGatos.Items.AddRange(new object[] {
            "Todos",
            "Apenas disponíveis",
            "Apenas adotados"});
            this.cbFiltroGatos.Location = new System.Drawing.Point(415, 16);
            this.cbFiltroGatos.Name = "cbFiltroGatos";
            this.cbFiltroGatos.Size = new System.Drawing.Size(185, 21);
            this.cbFiltroGatos.TabIndex = 4;
            // 
            // lblTituloConsultaGatos
            // 
            this.lblTituloConsultaGatos.AutoSize = true;
            this.lblTituloConsultaGatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultaGatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloConsultaGatos.Location = new System.Drawing.Point(15, 17);
            this.lblTituloConsultaGatos.Name = "lblTituloConsultaGatos";
            this.lblTituloConsultaGatos.Size = new System.Drawing.Size(159, 20);
            this.lblTituloConsultaGatos.TabIndex = 3;
            this.lblTituloConsultaGatos.Text = "Consulta de Gatos";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.dataGridView1);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 111);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(634, 669);
            this.pnlConteudo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSalvarTutor
            // 
            this.btnSalvarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnSalvarTutor.FlatAppearance.BorderSize = 0;
            this.btnSalvarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarTutor.Location = new System.Drawing.Point(524, 71);
            this.btnSalvarTutor.Name = "btnSalvarTutor";
            this.btnSalvarTutor.Size = new System.Drawing.Size(76, 25);
            this.btnSalvarTutor.TabIndex = 24;
            this.btnSalvarTutor.Text = "Buscar";
            this.btnSalvarTutor.UseVisualStyleBackColor = false;
            // 
            // ucConsultaGatos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "ucConsultaGatos1";
            this.Size = new System.Drawing.Size(634, 780);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblTituloConsultaGatos;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Label lblFiltrarGato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox cbFiltroGatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvarTutor;
    }
}
