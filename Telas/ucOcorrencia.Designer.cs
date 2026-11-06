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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpInfos = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblIdadeMicrochip = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtMicrochip = new System.Windows.Forms.TextBox();
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.pnlTipoOcorrência = new System.Windows.Forms.Panel();
            this.tlpTipos = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pnlDetalhesOcorrência = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvarOcorrencia = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.dtpDataOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.pnlSelecaoGato.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpInfos.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlTipoOcorrência.SuspendLayout();
            this.pnlDetalhesOcorrência.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnlSelecaoGato.Controls.Add(this.panel1);
            this.pnlSelecaoGato.Controls.Add(this.txtMicrochip);
            this.pnlSelecaoGato.Controls.Add(this.lblMicrochip);
            this.pnlSelecaoGato.Controls.Add(this.lblSelecao);
            this.pnlSelecaoGato.Location = new System.Drawing.Point(27, 82);
            this.pnlSelecaoGato.Name = "pnlSelecaoGato";
            this.pnlSelecaoGato.Size = new System.Drawing.Size(587, 116);
            this.pnlSelecaoGato.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tlpInfos);
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(243, 14);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(321, 85);
            this.panel1.TabIndex = 37;
            // 
            // tlpInfos
            // 
            this.tlpInfos.ColumnCount = 2;
            this.tlpInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInfos.Controls.Add(this.pnlDados, 0, 0);
            this.tlpInfos.Controls.Add(this.pnlStatus, 1, 0);
            this.tlpInfos.Location = new System.Drawing.Point(112, 6);
            this.tlpInfos.Name = "tlpInfos";
            this.tlpInfos.RowCount = 1;
            this.tlpInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfos.Size = new System.Drawing.Size(200, 71);
            this.tlpInfos.TabIndex = 5;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lblIdadeMicrochip);
            this.pnlDados.Controls.Add(this.lblNome);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(3, 3);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(114, 65);
            this.pnlDados.TabIndex = 0;
            // 
            // lblIdadeMicrochip
            // 
            this.lblIdadeMicrochip.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdadeMicrochip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeMicrochip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblIdadeMicrochip.Location = new System.Drawing.Point(0, 27);
            this.lblIdadeMicrochip.Name = "lblIdadeMicrochip";
            this.lblIdadeMicrochip.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblIdadeMicrochip.Size = new System.Drawing.Size(114, 34);
            this.lblIdadeMicrochip.TabIndex = 4;
            this.lblIdadeMicrochip.Text = "x anos . 12345";
            this.lblIdadeMicrochip.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNome.Size = new System.Drawing.Size(43, 27);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            this.lblNome.Visible = false;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(123, 3);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pnlStatus.Size = new System.Drawing.Size(74, 65);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(0, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Disponível";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFoto.Location = new System.Drawing.Point(6, 6);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 71);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            this.pbFoto.Visible = false;
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.txtMicrochip.Location = new System.Drawing.Point(19, 57);
            this.txtMicrochip.Multiline = true;
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.Size = new System.Drawing.Size(203, 25);
            this.txtMicrochip.TabIndex = 36;
            this.txtMicrochip.TextChanged += new System.EventHandler(this.txtMicrochip_TextChanged);
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.BackColor = System.Drawing.Color.White;
            this.lblMicrochip.Location = new System.Drawing.Point(19, 39);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMicrochip.Size = new System.Drawing.Size(110, 18);
            this.lblMicrochip.TabIndex = 35;
            this.lblMicrochip.Text = "Número do microchip:";
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
            // pnlTipoOcorrência
            // 
            this.pnlTipoOcorrência.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTipoOcorrência.Controls.Add(this.tlpTipos);
            this.pnlTipoOcorrência.Controls.Add(this.lblTipo);
            this.pnlTipoOcorrência.Location = new System.Drawing.Point(27, 217);
            this.pnlTipoOcorrência.Name = "pnlTipoOcorrência";
            this.pnlTipoOcorrência.Size = new System.Drawing.Size(587, 270);
            this.pnlTipoOcorrência.TabIndex = 33;
            // 
            // tlpTipos
            // 
            this.tlpTipos.ColumnCount = 3;
            this.tlpTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTipos.Location = new System.Drawing.Point(22, 29);
            this.tlpTipos.Name = "tlpTipos";
            this.tlpTipos.RowCount = 2;
            this.tlpTipos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipos.Size = new System.Drawing.Size(542, 221);
            this.tlpTipos.TabIndex = 35;
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
            // pnlDetalhesOcorrência
            // 
            this.pnlDetalhesOcorrência.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDetalhesOcorrência.Controls.Add(this.panel2);
            this.pnlDetalhesOcorrência.Controls.Add(this.lblDetalhes);
            this.pnlDetalhesOcorrência.Location = new System.Drawing.Point(27, 506);
            this.pnlDetalhesOcorrência.Name = "pnlDetalhesOcorrência";
            this.pnlDetalhesOcorrência.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetalhesOcorrência.Size = new System.Drawing.Size(587, 273);
            this.pnlDetalhesOcorrência.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.btnSalvarOcorrencia);
            this.panel2.Controls.Add(this.txtMotivo);
            this.panel2.Controls.Add(this.lblMotivo);
            this.panel2.Controls.Add(this.txtResponsavel);
            this.panel2.Controls.Add(this.lblResponsavel);
            this.panel2.Controls.Add(this.txtLocal);
            this.panel2.Controls.Add(this.lblLocal);
            this.panel2.Controls.Add(this.dtpDataOcorrencia);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 220);
            this.panel2.TabIndex = 35;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(201)))), ((int)(((byte)(198)))));
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(148)))));
            this.btnLimpar.Location = new System.Drawing.Point(198, 173);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 30);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvarOcorrencia
            // 
            this.btnSalvarOcorrencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnSalvarOcorrencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarOcorrencia.FlatAppearance.BorderSize = 0;
            this.btnSalvarOcorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarOcorrencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarOcorrencia.Location = new System.Drawing.Point(343, 173);
            this.btnSalvarOcorrencia.Name = "btnSalvarOcorrencia";
            this.btnSalvarOcorrencia.Size = new System.Drawing.Size(200, 30);
            this.btnSalvarOcorrencia.TabIndex = 45;
            this.btnSalvarOcorrencia.Text = "Salvar";
            this.btnSalvarOcorrencia.UseVisualStyleBackColor = false;
            this.btnSalvarOcorrencia.Click += new System.EventHandler(this.btnSalvarOcorrencia_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(15, 85);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.Size = new System.Drawing.Size(528, 64);
            this.txtMotivo.TabIndex = 44;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(12, 69);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(112, 13);
            this.lblMotivo.TabIndex = 43;
            this.lblMotivo.Text = "Motivo da Ocorrência:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(359, 30);
            this.txtResponsavel.Multiline = true;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(184, 25);
            this.txtResponsavel.TabIndex = 42;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(356, 14);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(137, 13);
            this.lblResponsavel.TabIndex = 41;
            this.lblResponsavel.Text = "Responsável pelo resgistro:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(154, 30);
            this.txtLocal.Multiline = true;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(199, 25);
            this.txtLocal.TabIndex = 40;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(151, 14);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(36, 13);
            this.lblLocal.TabIndex = 39;
            this.lblLocal.Text = "Local:";
            // 
            // dtpDataOcorrencia
            // 
            this.dtpDataOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataOcorrencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOcorrencia.Location = new System.Drawing.Point(15, 30);
            this.dtpDataOcorrencia.Name = "dtpDataOcorrencia";
            this.dtpDataOcorrencia.Size = new System.Drawing.Size(133, 24);
            this.dtpDataOcorrencia.TabIndex = 38;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(103, 13);
            this.lblData.TabIndex = 37;
            this.lblData.Text = "Data da Ocorrência:";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblDetalhes.Location = new System.Drawing.Point(15, 15);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetalhes.Size = new System.Drawing.Size(168, 23);
            this.lblDetalhes.TabIndex = 34;
            this.lblDetalhes.Text = "3. DETALHES DA OCORRÊNCIA";
            // 
            // ucOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlDetalhesOcorrência);
            this.Controls.Add(this.pnlTipoOcorrência);
            this.Controls.Add(this.pnlSelecaoGato);
            this.Controls.Add(this.lblCadastroTutor);
            this.Controls.Add(this.lblTituloRegistroOcorrencia);
            this.Name = "ucOcorrencia";
            this.Size = new System.Drawing.Size(640, 804);
            this.pnlSelecaoGato.ResumeLayout(false);
            this.pnlSelecaoGato.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpInfos.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlTipoOcorrência.ResumeLayout(false);
            this.pnlTipoOcorrência.PerformLayout();
            this.pnlDetalhesOcorrência.ResumeLayout(false);
            this.pnlDetalhesOcorrência.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtMicrochip;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpTipos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDataOcorrencia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvarOcorrencia;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TableLayoutPanel tlpInfos;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblIdadeMicrochip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}
