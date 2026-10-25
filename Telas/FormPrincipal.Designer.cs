namespace miaudota
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlPerfilContainer = new System.Windows.Forms.Panel();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.lblDisponibilidadeGato = new System.Windows.Forms.Label();
            this.lblMicrochipGato = new System.Windows.Forms.Label();
            this.lblIdadeGato = new System.Windows.Forms.Label();
            this.lblNomeGato = new System.Windows.Forms.Label();
            this.pbFotoGato = new System.Windows.Forms.PictureBox();
            this.btnConsultaTutor = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnCadastroTutor = new System.Windows.Forms.Button();
            this.btnCadastroGato = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlPerfilContainer.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnConsultaTutor);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.btnCadastroTutor);
            this.pnlMenu.Controls.Add(this.btnCadastroGato);
            this.pnlMenu.Controls.Add(this.pnlPerfilContainer);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 770);
            this.pnlMenu.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::miaudota.Properties.Resources.logoSemFundo2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(200, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(640, 770);
            this.pnlConteudo.TabIndex = 1;
            // 
            // pnlPerfilContainer
            // 
            this.pnlPerfilContainer.Controls.Add(this.pnlPerfil);
            this.pnlPerfilContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerfilContainer.Location = new System.Drawing.Point(0, 58);
            this.pnlPerfilContainer.Name = "pnlPerfilContainer";
            this.pnlPerfilContainer.Padding = new System.Windows.Forms.Padding(12);
            this.pnlPerfilContainer.Size = new System.Drawing.Size(200, 237);
            this.pnlPerfilContainer.TabIndex = 14;
            this.pnlPerfilContainer.Visible = false;
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pnlPerfil.Controls.Add(this.lblDisponibilidadeGato);
            this.pnlPerfil.Controls.Add(this.lblMicrochipGato);
            this.pnlPerfil.Controls.Add(this.lblIdadeGato);
            this.pnlPerfil.Controls.Add(this.lblNomeGato);
            this.pnlPerfil.Controls.Add(this.pbFotoGato);
            this.pnlPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPerfil.Location = new System.Drawing.Point(12, 12);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(176, 213);
            this.pnlPerfil.TabIndex = 9;
            // 
            // lblDisponibilidadeGato
            // 
            this.lblDisponibilidadeGato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDisponibilidadeGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisponibilidadeGato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidadeGato.Location = new System.Drawing.Point(0, 184);
            this.lblDisponibilidadeGato.Name = "lblDisponibilidadeGato";
            this.lblDisponibilidadeGato.Size = new System.Drawing.Size(176, 20);
            this.lblDisponibilidadeGato.TabIndex = 4;
            this.lblDisponibilidadeGato.Text = "Disponibilidade";
            this.lblDisponibilidadeGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMicrochipGato
            // 
            this.lblMicrochipGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMicrochipGato.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicrochipGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.lblMicrochipGato.Location = new System.Drawing.Point(0, 154);
            this.lblMicrochipGato.Name = "lblMicrochipGato";
            this.lblMicrochipGato.Size = new System.Drawing.Size(176, 30);
            this.lblMicrochipGato.TabIndex = 3;
            this.lblMicrochipGato.Text = "Microchip";
            this.lblMicrochipGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdadeGato
            // 
            this.lblIdadeGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdadeGato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblIdadeGato.Location = new System.Drawing.Point(0, 134);
            this.lblIdadeGato.Name = "lblIdadeGato";
            this.lblIdadeGato.Size = new System.Drawing.Size(176, 20);
            this.lblIdadeGato.TabIndex = 2;
            this.lblIdadeGato.Text = "Idade";
            this.lblIdadeGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeGato
            // 
            this.lblNomeGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeGato.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.lblNomeGato.Location = new System.Drawing.Point(0, 94);
            this.lblNomeGato.Name = "lblNomeGato";
            this.lblNomeGato.Size = new System.Drawing.Size(176, 40);
            this.lblNomeGato.TabIndex = 1;
            this.lblNomeGato.Text = "Nome";
            this.lblNomeGato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFotoGato
            // 
            this.pbFotoGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFotoGato.Location = new System.Drawing.Point(0, 0);
            this.pbFotoGato.Name = "pbFotoGato";
            this.pbFotoGato.Size = new System.Drawing.Size(176, 94);
            this.pbFotoGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoGato.TabIndex = 0;
            this.pbFotoGato.TabStop = false;
            // 
            // btnConsultaTutor
            // 
            this.btnConsultaTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaTutor.FlatAppearance.BorderSize = 0;
            this.btnConsultaTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnConsultaTutor.Location = new System.Drawing.Point(0, 400);
            this.btnConsultaTutor.Name = "btnConsultaTutor";
            this.btnConsultaTutor.Size = new System.Drawing.Size(200, 35);
            this.btnConsultaTutor.TabIndex = 18;
            this.btnConsultaTutor.Text = "📋 Consultar Tutores";
            this.btnConsultaTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTutor.UseVisualStyleBackColor = true;
            this.btnConsultaTutor.Click += new System.EventHandler(this.btnConsultaTutor_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnConsulta.Location = new System.Drawing.Point(0, 365);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(200, 35);
            this.btnConsulta.TabIndex = 17;
            this.btnConsulta.Text = "🔍 Consultar Gatos";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnCadastroTutor
            // 
            this.btnCadastroTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroTutor.FlatAppearance.BorderSize = 0;
            this.btnCadastroTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroTutor.Location = new System.Drawing.Point(0, 330);
            this.btnCadastroTutor.Name = "btnCadastroTutor";
            this.btnCadastroTutor.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroTutor.TabIndex = 16;
            this.btnCadastroTutor.Text = "👤 Cadastrar Tutor e Adoção";
            this.btnCadastroTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroTutor.UseVisualStyleBackColor = true;
            this.btnCadastroTutor.Click += new System.EventHandler(this.btnCadastroTutor_Click);
            // 
            // btnCadastroGato
            // 
            this.btnCadastroGato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroGato.FlatAppearance.BorderSize = 0;
            this.btnCadastroGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroGato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnCadastroGato.Location = new System.Drawing.Point(0, 295);
            this.btnCadastroGato.Name = "btnCadastroGato";
            this.btnCadastroGato.Size = new System.Drawing.Size(200, 35);
            this.btnCadastroGato.TabIndex = 15;
            this.btnCadastroGato.Text = "🐱 Cadastrar Gato";
            this.btnCadastroGato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroGato.UseVisualStyleBackColor = true;
            this.btnCadastroGato.Click += new System.EventHandler(this.btnCadastroGato_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 770);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormPrincipal";
            this.Text = "Miaudota";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlPerfilContainer.ResumeLayout(false);
            this.pnlPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlPerfilContainer;
        private System.Windows.Forms.Button btnConsultaTutor;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCadastroTutor;
        private System.Windows.Forms.Button btnCadastroGato;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Label lblDisponibilidadeGato;
        private System.Windows.Forms.Label lblMicrochipGato;
        private System.Windows.Forms.Label lblIdadeGato;
        private System.Windows.Forms.Label lblNomeGato;
        private System.Windows.Forms.PictureBox pbFotoGato;
    }
}