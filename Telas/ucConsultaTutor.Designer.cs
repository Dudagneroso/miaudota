namespace miaudota.Telas
{
    partial class ucConsultaTutor
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
            this.lblConsultaTutorSubtitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblTituloConsultaTutor = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.lblQtdTutores = new System.Windows.Forms.Label();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.pnlFiltros.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.lblConsultaTutorSubtitulo);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.txtPesquisar);
            this.pnlFiltros.Controls.Add(this.lblPesquisar);
            this.pnlFiltros.Controls.Add(this.lblTituloConsultaTutor);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(637, 111);
            this.pnlFiltros.TabIndex = 2;
            // 
            // lblConsultaTutorSubtitulo
            // 
            this.lblConsultaTutorSubtitulo.AutoSize = true;
            this.lblConsultaTutorSubtitulo.Location = new System.Drawing.Point(16, 46);
            this.lblConsultaTutorSubtitulo.Name = "lblConsultaTutorSubtitulo";
            this.lblConsultaTutorSubtitulo.Size = new System.Drawing.Size(249, 13);
            this.lblConsultaTutorSubtitulo.TabIndex = 25;
            this.lblConsultaTutorSubtitulo.Text = "Selecione um tutor para editar ou excluir o cadastro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(534, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 25);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(88, 71);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(440, 25);
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
            // lblTituloConsultaTutor
            // 
            this.lblTituloConsultaTutor.AutoSize = true;
            this.lblTituloConsultaTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultaTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloConsultaTutor.Location = new System.Drawing.Point(15, 17);
            this.lblTituloConsultaTutor.Name = "lblTituloConsultaTutor";
            this.lblTituloConsultaTutor.Size = new System.Drawing.Size(152, 20);
            this.lblTituloConsultaTutor.TabIndex = 3;
            this.lblTituloConsultaTutor.Text = "Consultar Tutores";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.lblQtdTutores);
            this.pnlConteudo.Controls.Add(this.dgvTutores);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(637, 799);
            this.pnlConteudo.TabIndex = 3;
            // 
            // lblQtdTutores
            // 
            this.lblQtdTutores.AutoSize = true;
            this.lblQtdTutores.Location = new System.Drawing.Point(24, 772);
            this.lblQtdTutores.Name = "lblQtdTutores";
            this.lblQtdTutores.Size = new System.Drawing.Size(54, 13);
            this.lblQtdTutores.TabIndex = 1;
            this.lblQtdTutores.Text = "0 tutor(es)";
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.dgvTutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(141)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(141)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutores.ColumnHeadersHeight = 40;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(141)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dgvTutores.Location = new System.Drawing.Point(27, 129);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            this.dgvTutores.RowHeadersVisible = false;
            this.dgvTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutores.Size = new System.Drawing.Size(583, 628);
            this.dgvTutores.TabIndex = 0;
            this.dgvTutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutores_CellClick);
            // 
            // ucConsultaTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlConteudo);
            this.Name = "ucConsultaTutor";
            this.Size = new System.Drawing.Size(637, 799);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblConsultaTutorSubtitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblTituloConsultaTutor;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.Label lblQtdTutores;
    }
}
