namespace miaudota.Telas
{
    partial class ucEdicaoGato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtDeficiencia = new System.Windows.Forms.TextBox();
            this.lblDeficiencias = new System.Windows.Forms.Label();
            this.clbVacinas = new System.Windows.Forms.CheckedListBox();
            this.lblCheckVacinas = new System.Windows.Forms.Label();
            this.tlpInfos = new System.Windows.Forms.TableLayoutPanel();
            this.gbCastracao = new System.Windows.Forms.GroupBox();
            this.rbNaoCastrado = new System.Windows.Forms.RadioButton();
            this.rbCastrado = new System.Windows.Forms.RadioButton();
            this.gbVacina = new System.Windows.Forms.GroupBox();
            this.rbNaoVacinado = new System.Windows.Forms.RadioButton();
            this.rbVacinado = new System.Windows.Forms.RadioButton();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEspaco = new System.Windows.Forms.Label();
            this.txtLarTemporario = new System.Windows.Forms.TextBox();
            this.lblLarTemporario = new System.Windows.Forms.Label();
            this.lblSaudeStatus = new System.Windows.Forms.Label();
            this.pnlCaracteristicas = new System.Windows.Forms.Panel();
            this.pnlPeso = new System.Windows.Forms.Panel();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.pnlPelagem = new System.Windows.Forms.Panel();
            this.cbColoracao = new System.Windows.Forms.ComboBox();
            this.lblColoracao = new System.Windows.Forms.Label();
            this.cbPelagem = new System.Windows.Forms.ComboBox();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMicrochip = new System.Windows.Forms.TextBox();
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblDescricaoPerfil = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tlpFotodoGato = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.btnEscolherFoto = new System.Windows.Forms.Button();
            this.pbFotoGato = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.gbCadastrarLocal = new System.Windows.Forms.GroupBox();
            this.rbNaoLocal = new System.Windows.Forms.RadioButton();
            this.rbSimLocal = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tlpInfos.SuspendLayout();
            this.gbCastracao.SuspendLayout();
            this.gbVacina.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlCaracteristicas.SuspendLayout();
            this.pnlPeso.SuspendLayout();
            this.pnlPelagem.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.tlpFotodoGato.SuspendLayout();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).BeginInit();
            this.gbCadastrarLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tlpFotodoGato);
            this.panel1.Controls.Add(this.dtpDataEntrada);
            this.panel1.Controls.Add(this.lblDataEntrada);
            this.panel1.Controls.Add(this.txtObservacoes);
            this.panel1.Controls.Add(this.lblObservacoes);
            this.panel1.Controls.Add(this.txtDeficiencia);
            this.panel1.Controls.Add(this.lblDeficiencias);
            this.panel1.Controls.Add(this.clbVacinas);
            this.panel1.Controls.Add(this.lblCheckVacinas);
            this.panel1.Controls.Add(this.tlpInfos);
            this.panel1.Controls.Add(this.lblEspaco);
            this.panel1.Controls.Add(this.txtLarTemporario);
            this.panel1.Controls.Add(this.lblLarTemporario);
            this.panel1.Controls.Add(this.lblSaudeStatus);
            this.panel1.Controls.Add(this.pnlCaracteristicas);
            this.panel1.Controls.Add(this.lblCaracteristicas);
            this.panel1.Controls.Add(this.dtpDataNascimento);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtMicrochip);
            this.panel1.Controls.Add(this.lblMicrochip);
            this.panel1.Controls.Add(this.lblIdentificacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(650, 1762);
            this.panel1.TabIndex = 0;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(15, 857);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(620, 20);
            this.dtpDataEntrada.TabIndex = 40;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataEntrada.Location = new System.Drawing.Point(15, 824);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Padding = new System.Windows.Forms.Padding(0, 15, 0, 5);
            this.lblDataEntrada.Size = new System.Drawing.Size(88, 33);
            this.lblDataEntrada.TabIndex = 39;
            this.lblDataEntrada.Text = "Data de Entrada:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtObservacoes.Location = new System.Drawing.Point(15, 745);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacoes.Size = new System.Drawing.Size(620, 79);
            this.txtObservacoes.TabIndex = 38;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblObservacoes.Location = new System.Drawing.Point(15, 712);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Padding = new System.Windows.Forms.Padding(0, 15, 0, 5);
            this.lblObservacoes.Size = new System.Drawing.Size(73, 33);
            this.lblObservacoes.TabIndex = 37;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtDeficiencia
            // 
            this.txtDeficiencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDeficiencia.Location = new System.Drawing.Point(15, 692);
            this.txtDeficiencia.Name = "txtDeficiencia";
            this.txtDeficiencia.Size = new System.Drawing.Size(620, 20);
            this.txtDeficiencia.TabIndex = 36;
            // 
            // lblDeficiencias
            // 
            this.lblDeficiencias.AutoSize = true;
            this.lblDeficiencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeficiencias.Location = new System.Drawing.Point(15, 664);
            this.lblDeficiencias.Name = "lblDeficiencias";
            this.lblDeficiencias.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblDeficiencias.Size = new System.Drawing.Size(189, 28);
            this.lblDeficiencias.TabIndex = 35;
            this.lblDeficiencias.Text = "Possui alguma doença ou deficiência?";
            // 
            // clbVacinas
            // 
            this.clbVacinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbVacinas.FormattingEnabled = true;
            this.clbVacinas.IntegralHeight = false;
            this.clbVacinas.Items.AddRange(new object[] {
            "Nobivac Tricat Trio",
            "Feline Vanguard Plus",
            "Felocell 4",
            "Leucogen",
            "Feline Vanguard Crv",
            "Purevax Recombinant FeLV",
            "Defensor",
            "Nobivac Raiva",
            "Rabisin",
            "Nobivac Bb"});
            this.clbVacinas.Location = new System.Drawing.Point(15, 567);
            this.clbVacinas.MultiColumn = true;
            this.clbVacinas.Name = "clbVacinas";
            this.clbVacinas.Size = new System.Drawing.Size(620, 97);
            this.clbVacinas.TabIndex = 30;
            // 
            // lblCheckVacinas
            // 
            this.lblCheckVacinas.AutoSize = true;
            this.lblCheckVacinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheckVacinas.Location = new System.Drawing.Point(15, 539);
            this.lblCheckVacinas.Name = "lblCheckVacinas";
            this.lblCheckVacinas.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblCheckVacinas.Size = new System.Drawing.Size(143, 28);
            this.lblCheckVacinas.TabIndex = 29;
            this.lblCheckVacinas.Text = "Marque as vacinas tomadas:";
            // 
            // tlpInfos
            // 
            this.tlpInfos.ColumnCount = 3;
            this.tlpInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfos.Controls.Add(this.gbCastracao, 0, 0);
            this.tlpInfos.Controls.Add(this.gbVacina, 1, 0);
            this.tlpInfos.Controls.Add(this.pnlStatus, 2, 0);
            this.tlpInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfos.Location = new System.Drawing.Point(15, 451);
            this.tlpInfos.Name = "tlpInfos";
            this.tlpInfos.RowCount = 1;
            this.tlpInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfos.Size = new System.Drawing.Size(620, 88);
            this.tlpInfos.TabIndex = 19;
            // 
            // gbCastracao
            // 
            this.gbCastracao.Controls.Add(this.rbNaoCastrado);
            this.gbCastracao.Controls.Add(this.rbCastrado);
            this.gbCastracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCastracao.Location = new System.Drawing.Point(3, 3);
            this.gbCastracao.Name = "gbCastracao";
            this.gbCastracao.Size = new System.Drawing.Size(200, 82);
            this.gbCastracao.TabIndex = 0;
            this.gbCastracao.TabStop = false;
            this.gbCastracao.Text = "Já foi Castrado?";
            // 
            // rbNaoCastrado
            // 
            this.rbNaoCastrado.AutoSize = true;
            this.rbNaoCastrado.Location = new System.Drawing.Point(12, 53);
            this.rbNaoCastrado.Name = "rbNaoCastrado";
            this.rbNaoCastrado.Size = new System.Drawing.Size(45, 17);
            this.rbNaoCastrado.TabIndex = 1;
            this.rbNaoCastrado.TabStop = true;
            this.rbNaoCastrado.Text = "Não";
            this.rbNaoCastrado.UseVisualStyleBackColor = true;
            // 
            // rbCastrado
            // 
            this.rbCastrado.AutoSize = true;
            this.rbCastrado.Location = new System.Drawing.Point(12, 30);
            this.rbCastrado.Name = "rbCastrado";
            this.rbCastrado.Size = new System.Drawing.Size(42, 17);
            this.rbCastrado.TabIndex = 0;
            this.rbCastrado.TabStop = true;
            this.rbCastrado.Text = "Sim";
            this.rbCastrado.UseVisualStyleBackColor = true;
            // 
            // gbVacina
            // 
            this.gbVacina.Controls.Add(this.rbNaoVacinado);
            this.gbVacina.Controls.Add(this.rbVacinado);
            this.gbVacina.Location = new System.Drawing.Point(209, 3);
            this.gbVacina.Name = "gbVacina";
            this.gbVacina.Size = new System.Drawing.Size(170, 82);
            this.gbVacina.TabIndex = 1;
            this.gbVacina.TabStop = false;
            this.gbVacina.Text = "Possui vacinas em dia?";
            // 
            // rbNaoVacinado
            // 
            this.rbNaoVacinado.AutoSize = true;
            this.rbNaoVacinado.Location = new System.Drawing.Point(16, 53);
            this.rbNaoVacinado.Name = "rbNaoVacinado";
            this.rbNaoVacinado.Size = new System.Drawing.Size(45, 17);
            this.rbNaoVacinado.TabIndex = 1;
            this.rbNaoVacinado.TabStop = true;
            this.rbNaoVacinado.Text = "Não";
            this.rbNaoVacinado.UseVisualStyleBackColor = true;
            // 
            // rbVacinado
            // 
            this.rbVacinado.AutoSize = true;
            this.rbVacinado.Location = new System.Drawing.Point(16, 30);
            this.rbVacinado.Name = "rbVacinado";
            this.rbVacinado.Size = new System.Drawing.Size(42, 17);
            this.rbVacinado.TabIndex = 0;
            this.rbVacinado.TabStop = true;
            this.rbVacinado.Text = "Sim";
            this.rbVacinado.UseVisualStyleBackColor = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.cbStatus);
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(415, 3);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(202, 82);
            this.pnlStatus.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Disponível",
            "Adotado"});
            this.cbStatus.Location = new System.Drawing.Point(0, 13);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(202, 21);
            this.cbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblEspaco
            // 
            this.lblEspaco.AutoSize = true;
            this.lblEspaco.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEspaco.Location = new System.Drawing.Point(15, 433);
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEspaco.Size = new System.Drawing.Size(0, 18);
            this.lblEspaco.TabIndex = 18;
            // 
            // txtLarTemporario
            // 
            this.txtLarTemporario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLarTemporario.Location = new System.Drawing.Point(15, 413);
            this.txtLarTemporario.Name = "txtLarTemporario";
            this.txtLarTemporario.Size = new System.Drawing.Size(620, 20);
            this.txtLarTemporario.TabIndex = 17;
            this.txtLarTemporario.TextChanged += new System.EventHandler(this.txtLarTemporario_TextChanged);
            // 
            // lblLarTemporario
            // 
            this.lblLarTemporario.AutoSize = true;
            this.lblLarTemporario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLarTemporario.Location = new System.Drawing.Point(15, 385);
            this.lblLarTemporario.Name = "lblLarTemporario";
            this.lblLarTemporario.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblLarTemporario.Size = new System.Drawing.Size(81, 28);
            this.lblLarTemporario.TabIndex = 16;
            this.lblLarTemporario.Text = "Lar Temporário:";
            // 
            // lblSaudeStatus
            // 
            this.lblSaudeStatus.AutoSize = true;
            this.lblSaudeStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaudeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblSaudeStatus.Location = new System.Drawing.Point(15, 332);
            this.lblSaudeStatus.Name = "lblSaudeStatus";
            this.lblSaudeStatus.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblSaudeStatus.Size = new System.Drawing.Size(100, 53);
            this.lblSaudeStatus.TabIndex = 15;
            this.lblSaudeStatus.Text = "SAÚDE E STATUS";
            // 
            // pnlCaracteristicas
            // 
            this.pnlCaracteristicas.Controls.Add(this.pnlPeso);
            this.pnlCaracteristicas.Controls.Add(this.pnlPelagem);
            this.pnlCaracteristicas.Controls.Add(this.gbSexo);
            this.pnlCaracteristicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaracteristicas.Location = new System.Drawing.Point(15, 230);
            this.pnlCaracteristicas.Name = "pnlCaracteristicas";
            this.pnlCaracteristicas.Size = new System.Drawing.Size(620, 102);
            this.pnlCaracteristicas.TabIndex = 14;
            // 
            // pnlPeso
            // 
            this.pnlPeso.Controls.Add(this.txbPeso);
            this.pnlPeso.Controls.Add(this.lblPeso);
            this.pnlPeso.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPeso.Location = new System.Drawing.Point(323, 0);
            this.pnlPeso.Name = "pnlPeso";
            this.pnlPeso.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlPeso.Size = new System.Drawing.Size(200, 102);
            this.pnlPeso.TabIndex = 13;
            // 
            // txbPeso
            // 
            this.txbPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbPeso.Location = new System.Drawing.Point(5, 18);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(190, 20);
            this.txbPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPeso.Location = new System.Drawing.Point(5, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPeso.Size = new System.Drawing.Size(56, 18);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso (Kg):";
            // 
            // pnlPelagem
            // 
            this.pnlPelagem.Controls.Add(this.cbColoracao);
            this.pnlPelagem.Controls.Add(this.lblColoracao);
            this.pnlPelagem.Controls.Add(this.cbPelagem);
            this.pnlPelagem.Controls.Add(this.lblPelagem);
            this.pnlPelagem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPelagem.Location = new System.Drawing.Point(125, 0);
            this.pnlPelagem.Name = "pnlPelagem";
            this.pnlPelagem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlPelagem.Size = new System.Drawing.Size(198, 102);
            this.pnlPelagem.TabIndex = 12;
            // 
            // cbColoracao
            // 
            this.cbColoracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColoracao.FormattingEnabled = true;
            this.cbColoracao.Items.AddRange(new object[] {
            "Preta",
            "Branca",
            "Vermelha/Laranja",
            "Cinza",
            "Marrom",
            "Tigrada",
            "Tricolor",
            "Frajola",
            "Bicolor",
            "Siamês",
            "Outros"});
            this.cbColoracao.Location = new System.Drawing.Point(5, 67);
            this.cbColoracao.Name = "cbColoracao";
            this.cbColoracao.Size = new System.Drawing.Size(188, 21);
            this.cbColoracao.TabIndex = 14;
            // 
            // lblColoracao
            // 
            this.lblColoracao.AutoSize = true;
            this.lblColoracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColoracao.Location = new System.Drawing.Point(5, 39);
            this.lblColoracao.Name = "lblColoracao";
            this.lblColoracao.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblColoracao.Size = new System.Drawing.Size(58, 28);
            this.lblColoracao.TabIndex = 13;
            this.lblColoracao.Text = "Coloração:";
            // 
            // cbPelagem
            // 
            this.cbPelagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPelagem.FormattingEnabled = true;
            this.cbPelagem.Items.AddRange(new object[] {
            "Curta",
            "Média",
            "Longa"});
            this.cbPelagem.Location = new System.Drawing.Point(5, 18);
            this.cbPelagem.Name = "cbPelagem";
            this.cbPelagem.Size = new System.Drawing.Size(188, 21);
            this.cbPelagem.TabIndex = 12;
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPelagem.Location = new System.Drawing.Point(5, 0);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPelagem.Size = new System.Drawing.Size(51, 18);
            this.lblPelagem.TabIndex = 11;
            this.lblPelagem.Text = "Pelagem:";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFemea);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSexo.Location = new System.Drawing.Point(0, 0);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(125, 102);
            this.gbSexo.TabIndex = 9;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.Location = new System.Drawing.Point(22, 52);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(60, 17);
            this.rbFemea.TabIndex = 1;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Femêa ";
            this.rbFemea.UseVisualStyleBackColor = true;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(22, 29);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 0;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblCaracteristicas.Location = new System.Drawing.Point(15, 177);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblCaracteristicas.Size = new System.Drawing.Size(106, 53);
            this.lblCaracteristicas.TabIndex = 7;
            this.lblCaracteristicas.Text = "CARACTERÍSTICAS";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(15, 157);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(620, 20);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataNascimento.Location = new System.Drawing.Point(15, 129);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 28);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Location = new System.Drawing.Point(15, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(620, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNome.Location = new System.Drawing.Point(15, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblNome.Size = new System.Drawing.Size(38, 28);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMicrochip.Location = new System.Drawing.Point(15, 61);
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.Size = new System.Drawing.Size(620, 20);
            this.txtMicrochip.TabIndex = 2;
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMicrochip.Location = new System.Drawing.Point(15, 43);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMicrochip.Size = new System.Drawing.Size(110, 18);
            this.lblMicrochip.TabIndex = 1;
            this.lblMicrochip.Text = "Número do microchip:";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdentificacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblIdentificacao.Location = new System.Drawing.Point(15, 15);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblIdentificacao.Size = new System.Drawing.Size(88, 28);
            this.lblIdentificacao.TabIndex = 0;
            this.lblIdentificacao.Text = "IDENTIFICAÇÃO";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPerfil.Location = new System.Drawing.Point(33, 13);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(120, 20);
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.Text = "Perfil do Gato";
            // 
            // lblDescricaoPerfil
            // 
            this.lblDescricaoPerfil.AutoSize = true;
            this.lblDescricaoPerfil.Location = new System.Drawing.Point(34, 42);
            this.lblDescricaoPerfil.Name = "lblDescricaoPerfil";
            this.lblDescricaoPerfil.Size = new System.Drawing.Size(251, 13);
            this.lblDescricaoPerfil.TabIndex = 2;
            this.lblDescricaoPerfil.Text = "Edite os dados do gatinho e salve as alterações 😸 ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
            this.btnExcluir.Location = new System.Drawing.Point(482, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "🗑️ Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // tlpFotodoGato
            // 
            this.tlpFotodoGato.ColumnCount = 2;
            this.tlpFotodoGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFotodoGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFotodoGato.Controls.Add(this.gbCadastrarLocal, 1, 0);
            this.tlpFotodoGato.Controls.Add(this.pnlFoto, 0, 0);
            this.tlpFotodoGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFotodoGato.Location = new System.Drawing.Point(15, 877);
            this.tlpFotodoGato.Name = "tlpFotodoGato";
            this.tlpFotodoGato.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlpFotodoGato.RowCount = 1;
            this.tlpFotodoGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFotodoGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tlpFotodoGato.Size = new System.Drawing.Size(620, 216);
            this.tlpFotodoGato.TabIndex = 41;
            // 
            // pnlFoto
            // 
            this.pnlFoto.Controls.Add(this.lblFoto);
            this.pnlFoto.Controls.Add(this.btnEscolherFoto);
            this.pnlFoto.Controls.Add(this.pbFotoGato);
            this.pnlFoto.Location = new System.Drawing.Point(3, 13);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(304, 200);
            this.pnlFoto.TabIndex = 42;
            // 
            // btnEscolherFoto
            // 
            this.btnEscolherFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnEscolherFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolherFoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEscolherFoto.FlatAppearance.BorderSize = 0;
            this.btnEscolherFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEscolherFoto.Location = new System.Drawing.Point(0, 170);
            this.btnEscolherFoto.Name = "btnEscolherFoto";
            this.btnEscolherFoto.Size = new System.Drawing.Size(304, 30);
            this.btnEscolherFoto.TabIndex = 39;
            this.btnEscolherFoto.Text = "Escolher Foto";
            this.btnEscolherFoto.UseVisualStyleBackColor = false;
            // 
            // pbFotoGato
            // 
            this.pbFotoGato.Location = new System.Drawing.Point(0, 16);
            this.pbFotoGato.Name = "pbFotoGato";
            this.pbFotoGato.Size = new System.Drawing.Size(319, 165);
            this.pbFotoGato.TabIndex = 0;
            this.pbFotoGato.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(0, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(72, 13);
            this.lblFoto.TabIndex = 40;
            this.lblFoto.Text = "Foto do Gato:";
            // 
            // gbCadastrarLocal
            // 
            this.gbCadastrarLocal.Controls.Add(this.rbNaoLocal);
            this.gbCadastrarLocal.Controls.Add(this.rbSimLocal);
            this.gbCadastrarLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCadastrarLocal.Location = new System.Drawing.Point(313, 13);
            this.gbCadastrarLocal.Name = "gbCadastrarLocal";
            this.gbCadastrarLocal.Size = new System.Drawing.Size(304, 200);
            this.gbCadastrarLocal.TabIndex = 43;
            this.gbCadastrarLocal.TabStop = false;
            this.gbCadastrarLocal.Text = "Deseja resgistar o local de resgate?";
            // 
            // rbNaoLocal
            // 
            this.rbNaoLocal.AutoSize = true;
            this.rbNaoLocal.Location = new System.Drawing.Point(16, 66);
            this.rbNaoLocal.Name = "rbNaoLocal";
            this.rbNaoLocal.Size = new System.Drawing.Size(45, 17);
            this.rbNaoLocal.TabIndex = 30;
            this.rbNaoLocal.TabStop = true;
            this.rbNaoLocal.Text = "Não";
            this.rbNaoLocal.UseVisualStyleBackColor = true;
            // 
            // rbSimLocal
            // 
            this.rbSimLocal.AutoSize = true;
            this.rbSimLocal.Location = new System.Drawing.Point(16, 33);
            this.rbSimLocal.Name = "rbSimLocal";
            this.rbSimLocal.Size = new System.Drawing.Size(42, 17);
            this.rbSimLocal.TabIndex = 29;
            this.rbSimLocal.TabStop = true;
            this.rbSimLocal.Text = "Sim";
            this.rbSimLocal.UseVisualStyleBackColor = true;
            // 
            // ucEdicaoGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblDescricaoPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucEdicaoGato";
            this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 0);
            this.Size = new System.Drawing.Size(710, 1832);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpInfos.ResumeLayout(false);
            this.gbCastracao.ResumeLayout(false);
            this.gbCastracao.PerformLayout();
            this.gbVacina.ResumeLayout(false);
            this.gbVacina.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlCaracteristicas.ResumeLayout(false);
            this.pnlPeso.ResumeLayout(false);
            this.pnlPeso.PerformLayout();
            this.pnlPelagem.ResumeLayout(false);
            this.pnlPelagem.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.tlpFotodoGato.ResumeLayout(false);
            this.pnlFoto.ResumeLayout(false);
            this.pnlFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).EndInit();
            this.gbCadastrarLocal.ResumeLayout(false);
            this.gbCadastrarLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblDescricaoPerfil;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.TextBox txtMicrochip;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSaudeStatus;
        private System.Windows.Forms.Panel pnlCaracteristicas;
        private System.Windows.Forms.Panel pnlPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Panel pnlPelagem;
        private System.Windows.Forms.ComboBox cbColoracao;
        private System.Windows.Forms.Label lblColoracao;
        private System.Windows.Forms.ComboBox cbPelagem;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.Label lblLarTemporario;
        private System.Windows.Forms.TextBox txtLarTemporario;
        private System.Windows.Forms.TableLayoutPanel tlpInfos;
        private System.Windows.Forms.GroupBox gbCastracao;
        private System.Windows.Forms.Label lblEspaco;
        private System.Windows.Forms.RadioButton rbNaoCastrado;
        private System.Windows.Forms.RadioButton rbCastrado;
        private System.Windows.Forms.GroupBox gbVacina;
        private System.Windows.Forms.RadioButton rbNaoVacinado;
        private System.Windows.Forms.RadioButton rbVacinado;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblCheckVacinas;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtDeficiencia;
        private System.Windows.Forms.Label lblDeficiencias;
        private System.Windows.Forms.CheckedListBox clbVacinas;
        private System.Windows.Forms.TableLayoutPanel tlpFotodoGato;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnEscolherFoto;
        private System.Windows.Forms.PictureBox pbFotoGato;
        private System.Windows.Forms.GroupBox gbCadastrarLocal;
        private System.Windows.Forms.RadioButton rbNaoLocal;
        private System.Windows.Forms.RadioButton rbSimLocal;
    }
}
