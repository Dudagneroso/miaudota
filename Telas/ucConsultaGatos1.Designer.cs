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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblConsultaGatosSubtitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFiltrarGato = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.cbFiltroGatos = new System.Windows.Forms.ComboBox();
            this.lblTituloConsultaGatos = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.dgvGatos = new System.Windows.Forms.DataGridView();
            this.pnlFiltros.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.lblConsultaGatosSubtitulo);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.lblFiltrarGato);
            this.pnlFiltros.Controls.Add(this.txtPesquisar);
            this.pnlFiltros.Controls.Add(this.lblPesquisar);
            this.pnlFiltros.Controls.Add(this.cbFiltroGatos);
            this.pnlFiltros.Controls.Add(this.lblTituloConsultaGatos);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(634, 111);
            this.pnlFiltros.TabIndex = 0;
            // 
            // lblConsultaGatosSubtitulo
            // 
            this.lblConsultaGatosSubtitulo.AutoSize = true;
            this.lblConsultaGatosSubtitulo.Location = new System.Drawing.Point(16, 46);
            this.lblConsultaGatosSubtitulo.Name = "lblConsultaGatosSubtitulo";
            this.lblConsultaGatosSubtitulo.Size = new System.Drawing.Size(254, 13);
            this.lblConsultaGatosSubtitulo.TabIndex = 25;
            this.lblConsultaGatosSubtitulo.Text = "Clique em um gato para ver e editar o perfil completo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(524, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 25);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(88, 71);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(430, 25);
            this.txtPesquisar.TabIndex = 6;
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
            this.pnlConteudo.Controls.Add(this.dgvGatos);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 111);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(634, 669);
            this.pnlConteudo.TabIndex = 1;
            // 
            // dgvGatos
            // 
            this.dgvGatos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.dgvGatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(141)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(141)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGatos.ColumnHeadersHeight = 40;
            this.dgvGatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(141)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGatos.EnableHeadersVisualStyles = false;
            this.dgvGatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dgvGatos.Location = new System.Drawing.Point(27, 16);
            this.dgvGatos.Name = "dgvGatos";
            this.dgvGatos.ReadOnly = true;
            this.dgvGatos.RowHeadersVisible = false;
            this.dgvGatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGatos.Size = new System.Drawing.Size(573, 619);
            this.dgvGatos.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblTituloConsultaGatos;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Label lblFiltrarGato;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox cbFiltroGatos;
        private System.Windows.Forms.DataGridView dgvGatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblConsultaGatosSubtitulo;
    }
}
