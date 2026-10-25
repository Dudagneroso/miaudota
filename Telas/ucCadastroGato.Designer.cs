namespace miaudota
{
    partial class ucCadastroGato
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
            this.lblTituloCadastroGato = new System.Windows.Forms.Label();
            this.lblDeficiencias = new System.Windows.Forms.Label();
            this.txtDeficiencias = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEscolherFoto = new System.Windows.Forms.Label();
            this.btnEscolherFoto = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvarGato = new System.Windows.Forms.Button();
            this.pbFotoGato = new System.Windows.Forms.PictureBox();
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.txtMicrochip = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.lblColoracao = new System.Windows.Forms.Label();
            this.cbColoracao = new System.Windows.Forms.ComboBox();
            this.lblLarTemporario = new System.Windows.Forms.Label();
            this.txtLarTemporario = new System.Windows.Forms.TextBox();
            this.rbCastrado = new System.Windows.Forms.RadioButton();
            this.rbNaoCastrado = new System.Windows.Forms.RadioButton();
            this.gbCastracao = new System.Windows.Forms.GroupBox();
            this.rbVacinaSim = new System.Windows.Forms.RadioButton();
            this.rbVacinaNao = new System.Windows.Forms.RadioButton();
            this.gbVacinas = new System.Windows.Forms.GroupBox();
            this.pnlCadastroGato = new System.Windows.Forms.Panel();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblIdentificação = new System.Windows.Forms.Label();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.wvMapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.gbCadastrarLocal = new System.Windows.Forms.GroupBox();
            this.rbNaoLocal = new System.Windows.Forms.RadioButton();
            this.rbSimLocal = new System.Windows.Forms.RadioButton();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblCadastroSubtitulo = new System.Windows.Forms.Label();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.cbPelagem = new System.Windows.Forms.ComboBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSaudeStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbCastracao.SuspendLayout();
            this.gbVacinas.SuspendLayout();
            this.pnlCadastroGato.SuspendLayout();
            this.pnlMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvMapa)).BeginInit();
            this.gbCadastrarLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCadastroGato
            // 
            this.lblTituloCadastroGato.AutoSize = true;
            this.lblTituloCadastroGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloCadastroGato.Location = new System.Drawing.Point(16, 16);
            this.lblTituloCadastroGato.Name = "lblTituloCadastroGato";
            this.lblTituloCadastroGato.Size = new System.Drawing.Size(133, 20);
            this.lblTituloCadastroGato.TabIndex = 0;
            this.lblTituloCadastroGato.Text = "Cadastrar Gato";
            // 
            // lblDeficiencias
            // 
            this.lblDeficiencias.AutoSize = true;
            this.lblDeficiencias.BackColor = System.Drawing.Color.White;
            this.lblDeficiencias.Location = new System.Drawing.Point(7, 521);
            this.lblDeficiencias.Name = "lblDeficiencias";
            this.lblDeficiencias.Size = new System.Drawing.Size(189, 13);
            this.lblDeficiencias.TabIndex = 15;
            this.lblDeficiencias.Text = "Possui alguma doença ou deficiência?";
            // 
            // txtDeficiencias
            // 
            this.txtDeficiencias.Location = new System.Drawing.Point(10, 537);
            this.txtDeficiencias.Multiline = true;
            this.txtDeficiencias.Name = "txtDeficiencias";
            this.txtDeficiencias.Size = new System.Drawing.Size(545, 25);
            this.txtDeficiencias.TabIndex = 16;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.White;
            this.lblObservacao.Location = new System.Drawing.Point(10, 581);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(73, 13);
            this.lblObservacao.TabIndex = 17;
            this.lblObservacao.Text = "Observações:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 597);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(544, 79);
            this.textBox1.TabIndex = 18;
            // 
            // lblEscolherFoto
            // 
            this.lblEscolherFoto.AutoSize = true;
            this.lblEscolherFoto.BackColor = System.Drawing.Color.White;
            this.lblEscolherFoto.Location = new System.Drawing.Point(8, 749);
            this.lblEscolherFoto.Name = "lblEscolherFoto";
            this.lblEscolherFoto.Size = new System.Drawing.Size(72, 13);
            this.lblEscolherFoto.TabIndex = 20;
            this.lblEscolherFoto.Text = "Foto do Gato:";
            // 
            // btnEscolherFoto
            // 
            this.btnEscolherFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnEscolherFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolherFoto.FlatAppearance.BorderSize = 0;
            this.btnEscolherFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEscolherFoto.Location = new System.Drawing.Point(11, 873);
            this.btnEscolherFoto.Name = "btnEscolherFoto";
            this.btnEscolherFoto.Size = new System.Drawing.Size(200, 30);
            this.btnEscolherFoto.TabIndex = 21;
            this.btnEscolherFoto.Text = "Escolher Foto";
            this.btnEscolherFoto.UseVisualStyleBackColor = false;
            this.btnEscolherFoto.Click += new System.EventHandler(this.btnEscolherFoto_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            // 
            // btnSalvarGato
            // 
            this.btnSalvarGato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(201)))), ((int)(((byte)(200)))));
            this.btnSalvarGato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarGato.FlatAppearance.BorderSize = 0;
            this.btnSalvarGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarGato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarGato.Location = new System.Drawing.Point(355, 1303);
            this.btnSalvarGato.Name = "btnSalvarGato";
            this.btnSalvarGato.Size = new System.Drawing.Size(200, 30);
            this.btnSalvarGato.TabIndex = 22;
            this.btnSalvarGato.Text = "Salvar";
            this.btnSalvarGato.UseVisualStyleBackColor = false;
            // 
            // pbFotoGato
            // 
            this.pbFotoGato.BackColor = System.Drawing.Color.White;
            this.pbFotoGato.Location = new System.Drawing.Point(11, 765);
            this.pbFotoGato.Name = "pbFotoGato";
            this.pbFotoGato.Size = new System.Drawing.Size(197, 102);
            this.pbFotoGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoGato.TabIndex = 19;
            this.pbFotoGato.TabStop = false;
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.BackColor = System.Drawing.Color.White;
            this.lblMicrochip.Location = new System.Drawing.Point(6, 44);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Size = new System.Drawing.Size(110, 13);
            this.lblMicrochip.TabIndex = 1;
            this.lblMicrochip.Text = "Número do microchip:";
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.Location = new System.Drawing.Point(9, 60);
            this.txtMicrochip.Multiline = true;
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.Size = new System.Drawing.Size(538, 25);
            this.txtMicrochip.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(7, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 113);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(538, 25);
            this.txtNome.TabIndex = 4;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(15, 23);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 0;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.Location = new System.Drawing.Point(15, 46);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(57, 17);
            this.rbFemea.TabIndex = 1;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Femêa";
            this.rbFemea.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.Color.White;
            this.gbSexo.Controls.Add(this.rbFemea);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Location = new System.Drawing.Point(10, 235);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(119, 91);
            this.gbSexo.TabIndex = 6;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // lblColoracao
            // 
            this.lblColoracao.AutoSize = true;
            this.lblColoracao.BackColor = System.Drawing.Color.White;
            this.lblColoracao.Location = new System.Drawing.Point(138, 285);
            this.lblColoracao.Name = "lblColoracao";
            this.lblColoracao.Size = new System.Drawing.Size(58, 13);
            this.lblColoracao.TabIndex = 7;
            this.lblColoracao.Text = "Coloração:";
            // 
            // cbColoracao
            // 
            this.cbColoracao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColoracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbColoracao.Location = new System.Drawing.Point(138, 301);
            this.cbColoracao.Name = "cbColoracao";
            this.cbColoracao.Size = new System.Drawing.Size(198, 24);
            this.cbColoracao.TabIndex = 8;
            // 
            // lblLarTemporario
            // 
            this.lblLarTemporario.AutoSize = true;
            this.lblLarTemporario.BackColor = System.Drawing.Color.White;
            this.lblLarTemporario.Location = new System.Drawing.Point(10, 378);
            this.lblLarTemporario.Name = "lblLarTemporario";
            this.lblLarTemporario.Size = new System.Drawing.Size(81, 13);
            this.lblLarTemporario.TabIndex = 11;
            this.lblLarTemporario.Text = "Lar Temporário:";
            // 
            // txtLarTemporario
            // 
            this.txtLarTemporario.Location = new System.Drawing.Point(10, 394);
            this.txtLarTemporario.Multiline = true;
            this.txtLarTemporario.Name = "txtLarTemporario";
            this.txtLarTemporario.Size = new System.Drawing.Size(545, 25);
            this.txtLarTemporario.TabIndex = 12;
            // 
            // rbCastrado
            // 
            this.rbCastrado.AutoSize = true;
            this.rbCastrado.Location = new System.Drawing.Point(18, 22);
            this.rbCastrado.Name = "rbCastrado";
            this.rbCastrado.Size = new System.Drawing.Size(42, 17);
            this.rbCastrado.TabIndex = 0;
            this.rbCastrado.TabStop = true;
            this.rbCastrado.Text = "Sim";
            this.rbCastrado.UseVisualStyleBackColor = true;
            // 
            // rbNaoCastrado
            // 
            this.rbNaoCastrado.AutoSize = true;
            this.rbNaoCastrado.Location = new System.Drawing.Point(18, 45);
            this.rbNaoCastrado.Name = "rbNaoCastrado";
            this.rbNaoCastrado.Size = new System.Drawing.Size(45, 17);
            this.rbNaoCastrado.TabIndex = 1;
            this.rbNaoCastrado.TabStop = true;
            this.rbNaoCastrado.Text = "Não";
            this.rbNaoCastrado.UseVisualStyleBackColor = true;
            // 
            // gbCastracao
            // 
            this.gbCastracao.BackColor = System.Drawing.Color.White;
            this.gbCastracao.Controls.Add(this.rbNaoCastrado);
            this.gbCastracao.Controls.Add(this.rbCastrado);
            this.gbCastracao.Location = new System.Drawing.Point(11, 434);
            this.gbCastracao.Name = "gbCastracao";
            this.gbCastracao.Size = new System.Drawing.Size(141, 72);
            this.gbCastracao.TabIndex = 13;
            this.gbCastracao.TabStop = false;
            this.gbCastracao.Text = "Já foi Castrado?";
            // 
            // rbVacinaSim
            // 
            this.rbVacinaSim.AutoSize = true;
            this.rbVacinaSim.Location = new System.Drawing.Point(18, 22);
            this.rbVacinaSim.Name = "rbVacinaSim";
            this.rbVacinaSim.Size = new System.Drawing.Size(42, 17);
            this.rbVacinaSim.TabIndex = 0;
            this.rbVacinaSim.TabStop = true;
            this.rbVacinaSim.Text = "Sim";
            this.rbVacinaSim.UseVisualStyleBackColor = true;
            // 
            // rbVacinaNao
            // 
            this.rbVacinaNao.AutoSize = true;
            this.rbVacinaNao.Location = new System.Drawing.Point(18, 45);
            this.rbVacinaNao.Name = "rbVacinaNao";
            this.rbVacinaNao.Size = new System.Drawing.Size(45, 17);
            this.rbVacinaNao.TabIndex = 1;
            this.rbVacinaNao.TabStop = true;
            this.rbVacinaNao.Text = "Não";
            this.rbVacinaNao.UseVisualStyleBackColor = true;
            // 
            // gbVacinas
            // 
            this.gbVacinas.BackColor = System.Drawing.Color.White;
            this.gbVacinas.Controls.Add(this.rbVacinaNao);
            this.gbVacinas.Controls.Add(this.rbVacinaSim);
            this.gbVacinas.Location = new System.Drawing.Point(165, 434);
            this.gbVacinas.Name = "gbVacinas";
            this.gbVacinas.Size = new System.Drawing.Size(143, 72);
            this.gbVacinas.TabIndex = 14;
            this.gbVacinas.TabStop = false;
            this.gbVacinas.Text = "Possui vacinas em dia?";
            // 
            // pnlCadastroGato
            // 
            this.pnlCadastroGato.BackColor = System.Drawing.Color.White;
            this.pnlCadastroGato.Controls.Add(this.lblSaudeStatus);
            this.pnlCadastroGato.Controls.Add(this.lblPeso);
            this.pnlCadastroGato.Controls.Add(this.textBox2);
            this.pnlCadastroGato.Controls.Add(this.lblPelagem);
            this.pnlCadastroGato.Controls.Add(this.cbPelagem);
            this.pnlCadastroGato.Controls.Add(this.lblCaracteristicas);
            this.pnlCadastroGato.Controls.Add(this.dtpDataNascimento);
            this.pnlCadastroGato.Controls.Add(this.lblDataNascimento);
            this.pnlCadastroGato.Controls.Add(this.lblIdentificação);
            this.pnlCadastroGato.Controls.Add(this.pnlMapa);
            this.pnlCadastroGato.Controls.Add(this.txtNome);
            this.pnlCadastroGato.Controls.Add(this.lblNome);
            this.pnlCadastroGato.Controls.Add(this.gbSexo);
            this.pnlCadastroGato.Controls.Add(this.txtMicrochip);
            this.pnlCadastroGato.Controls.Add(this.lblColoracao);
            this.pnlCadastroGato.Controls.Add(this.lblMicrochip);
            this.pnlCadastroGato.Controls.Add(this.cbColoracao);
            this.pnlCadastroGato.Controls.Add(this.lblLarTemporario);
            this.pnlCadastroGato.Controls.Add(this.txtLarTemporario);
            this.pnlCadastroGato.Controls.Add(this.lblObservacao);
            this.pnlCadastroGato.Controls.Add(this.textBox1);
            this.pnlCadastroGato.Controls.Add(this.gbCadastrarLocal);
            this.pnlCadastroGato.Controls.Add(this.dtpDataEntrada);
            this.pnlCadastroGato.Controls.Add(this.lblDataEntrada);
            this.pnlCadastroGato.Controls.Add(this.btnLimpar);
            this.pnlCadastroGato.Controls.Add(this.txtDeficiencias);
            this.pnlCadastroGato.Controls.Add(this.lblDeficiencias);
            this.pnlCadastroGato.Controls.Add(this.lblSatus);
            this.pnlCadastroGato.Controls.Add(this.cbStatus);
            this.pnlCadastroGato.Controls.Add(this.gbCastracao);
            this.pnlCadastroGato.Controls.Add(this.gbVacinas);
            this.pnlCadastroGato.Controls.Add(this.btnEscolherFoto);
            this.pnlCadastroGato.Controls.Add(this.btnSalvarGato);
            this.pnlCadastroGato.Controls.Add(this.lblEscolherFoto);
            this.pnlCadastroGato.Controls.Add(this.pbFotoGato);
            this.pnlCadastroGato.Location = new System.Drawing.Point(20, 70);
            this.pnlCadastroGato.Name = "pnlCadastroGato";
            this.pnlCadastroGato.Size = new System.Drawing.Size(575, 1352);
            this.pnlCadastroGato.TabIndex = 23;
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblCaracteristicas.Location = new System.Drawing.Point(8, 208);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(106, 13);
            this.lblCaracteristicas.TabIndex = 35;
            this.lblCaracteristicas.Text = "CARACTERÍSTICAS";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(11, 164);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(539, 20);
            this.dtpDataNascimento.TabIndex = 34;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(10, 148);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 33;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblIdentificação
            // 
            this.lblIdentificação.AutoSize = true;
            this.lblIdentificação.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblIdentificação.Location = new System.Drawing.Point(7, 13);
            this.lblIdentificação.Name = "lblIdentificação";
            this.lblIdentificação.Size = new System.Drawing.Size(88, 13);
            this.lblIdentificação.TabIndex = 32;
            this.lblIdentificação.Text = "IDENTIFICAÇÃO";
            // 
            // pnlMapa
            // 
            this.pnlMapa.Controls.Add(this.label1);
            this.pnlMapa.Controls.Add(this.wvMapa);
            this.pnlMapa.Location = new System.Drawing.Point(13, 908);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(537, 370);
            this.pnlMapa.TabIndex = 31;
            this.pnlMapa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Local de resgate:";
            // 
            // wvMapa
            // 
            this.wvMapa.AllowExternalDrop = true;
            this.wvMapa.CreationProperties = null;
            this.wvMapa.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvMapa.Location = new System.Drawing.Point(6, 28);
            this.wvMapa.Name = "wvMapa";
            this.wvMapa.Size = new System.Drawing.Size(517, 336);
            this.wvMapa.TabIndex = 31;
            this.wvMapa.ZoomFactor = 1D;
            // 
            // gbCadastrarLocal
            // 
            this.gbCadastrarLocal.Controls.Add(this.rbNaoLocal);
            this.gbCadastrarLocal.Controls.Add(this.rbSimLocal);
            this.gbCadastrarLocal.Location = new System.Drawing.Point(240, 749);
            this.gbCadastrarLocal.Name = "gbCadastrarLocal";
            this.gbCadastrarLocal.Size = new System.Drawing.Size(196, 109);
            this.gbCadastrarLocal.TabIndex = 28;
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
            this.rbSimLocal.CheckedChanged += new System.EventHandler(this.rbSimLocal_CheckedChanged);
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(11, 704);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(539, 20);
            this.dtpDataEntrada.TabIndex = 27;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.BackColor = System.Drawing.Color.White;
            this.lblDataEntrada.Location = new System.Drawing.Point(8, 688);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(88, 13);
            this.lblDataEntrada.TabIndex = 26;
            this.lblDataEntrada.Text = "Data de Entrada:";
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
            this.btnLimpar.Location = new System.Drawing.Point(210, 1303);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 30);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // lblSatus
            // 
            this.lblSatus.AutoSize = true;
            this.lblSatus.Location = new System.Drawing.Point(323, 434);
            this.lblSatus.Name = "lblSatus";
            this.lblSatus.Size = new System.Drawing.Size(40, 13);
            this.lblSatus.TabIndex = 24;
            this.lblSatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Disponível",
            "Adotado"});
            this.cbStatus.Location = new System.Drawing.Point(323, 450);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(232, 23);
            this.cbStatus.TabIndex = 23;
            // 
            // lblCadastroSubtitulo
            // 
            this.lblCadastroSubtitulo.Location = new System.Drawing.Point(17, 45);
            this.lblCadastroSubtitulo.Name = "lblCadastroSubtitulo";
            this.lblCadastroSubtitulo.Size = new System.Drawing.Size(212, 13);
            this.lblCadastroSubtitulo.TabIndex = 24;
            this.lblCadastroSubtitulo.Text = "Preencha os dados do novo gatinho 🐱";
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.BackColor = System.Drawing.Color.White;
            this.lblPelagem.Location = new System.Drawing.Point(138, 234);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Size = new System.Drawing.Size(51, 13);
            this.lblPelagem.TabIndex = 36;
            this.lblPelagem.Text = "Pelagem:";
            // 
            // cbPelagem
            // 
            this.cbPelagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPelagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPelagem.FormattingEnabled = true;
            this.cbPelagem.Items.AddRange(new object[] {
            "Curta",
            "Média",
            "Longa"});
            this.cbPelagem.Location = new System.Drawing.Point(138, 250);
            this.cbPelagem.Name = "cbPelagem";
            this.cbPelagem.Size = new System.Drawing.Size(198, 24);
            this.cbPelagem.TabIndex = 37;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(346, 234);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(56, 13);
            this.lblPeso.TabIndex = 38;
            this.lblPeso.Text = "Peso (Kg):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 250);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 25);
            this.textBox2.TabIndex = 39;
            // 
            // lblSaudeStatus
            // 
            this.lblSaudeStatus.AutoSize = true;
            this.lblSaudeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.lblSaudeStatus.Location = new System.Drawing.Point(10, 349);
            this.lblSaudeStatus.Name = "lblSaudeStatus";
            this.lblSaudeStatus.Size = new System.Drawing.Size(100, 13);
            this.lblSaudeStatus.TabIndex = 40;
            this.lblSaudeStatus.Text = "SAÚDE E STATUS";
            // 
            // ucCadastroGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lblCadastroSubtitulo);
            this.Controls.Add(this.lblTituloCadastroGato);
            this.Controls.Add(this.pnlCadastroGato);
            this.Name = "ucCadastroGato";
            this.Size = new System.Drawing.Size(620, 1439);
            this.Load += new System.EventHandler(this.ucCadastroGato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbCastracao.ResumeLayout(false);
            this.gbCastracao.PerformLayout();
            this.gbVacinas.ResumeLayout(false);
            this.gbVacinas.PerformLayout();
            this.pnlCadastroGato.ResumeLayout(false);
            this.pnlCadastroGato.PerformLayout();
            this.pnlMapa.ResumeLayout(false);
            this.pnlMapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvMapa)).EndInit();
            this.gbCadastrarLocal.ResumeLayout(false);
            this.gbCadastrarLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastroGato;
        private System.Windows.Forms.Label lblDeficiencias;
        private System.Windows.Forms.TextBox txtDeficiencias;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbFotoGato;
        private System.Windows.Forms.Label lblEscolherFoto;
        private System.Windows.Forms.Button btnEscolherFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnSalvarGato;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.TextBox txtMicrochip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.Label lblColoracao;
        private System.Windows.Forms.ComboBox cbColoracao;
        private System.Windows.Forms.Label lblLarTemporario;
        private System.Windows.Forms.TextBox txtLarTemporario;
        private System.Windows.Forms.RadioButton rbCastrado;
        private System.Windows.Forms.RadioButton rbNaoCastrado;
        private System.Windows.Forms.GroupBox gbCastracao;
        private System.Windows.Forms.RadioButton rbVacinaSim;
        private System.Windows.Forms.RadioButton rbVacinaNao;
        private System.Windows.Forms.GroupBox gbVacinas;
        private System.Windows.Forms.Panel pnlCadastroGato;
        private System.Windows.Forms.Label lblSatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblCadastroSubtitulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.GroupBox gbCadastrarLocal;
        private System.Windows.Forms.RadioButton rbNaoLocal;
        private System.Windows.Forms.RadioButton rbSimLocal;
        private System.Windows.Forms.Panel pnlMapa;
        private System.Windows.Forms.Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvMapa;
        private System.Windows.Forms.Label lblIdentificação;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.ComboBox cbPelagem;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSaudeStatus;
    }
}
