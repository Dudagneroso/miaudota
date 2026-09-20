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
            this.btnCadastroTutor = new System.Windows.Forms.Button();
            this.btnCadastroGato = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMenu.Controls.Add(this.btnCadastroTutor);
            this.pnlMenu.Controls.Add(this.btnCadastroGato);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 770);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCadastroTutor
            // 
            this.btnCadastroTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroTutor.FlatAppearance.BorderSize = 0;
            this.btnCadastroTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroTutor.Location = new System.Drawing.Point(0, 118);
            this.btnCadastroTutor.Name = "btnCadastroTutor";
            this.btnCadastroTutor.Size = new System.Drawing.Size(200, 30);
            this.btnCadastroTutor.TabIndex = 5;
            this.btnCadastroTutor.Text = "Cadastrar Tutor e Adoção";
            this.btnCadastroTutor.UseVisualStyleBackColor = true;
            this.btnCadastroTutor.Click += new System.EventHandler(this.btnCadastroTutor_Click);
            // 
            // btnCadastroGato
            // 
            this.btnCadastroGato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroGato.FlatAppearance.BorderSize = 0;
            this.btnCadastroGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGato.Location = new System.Drawing.Point(0, 88);
            this.btnCadastroGato.Name = "btnCadastroGato";
            this.btnCadastroGato.Size = new System.Drawing.Size(200, 30);
            this.btnCadastroGato.TabIndex = 4;
            this.btnCadastroGato.Text = "Cadastrar Gato";
            this.btnCadastroGato.UseVisualStyleBackColor = true;
            this.btnCadastroGato.Click += new System.EventHandler(this.btnCadastroGato_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(0, 58);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(200, 30);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consultar Gatos";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(200, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(640, 770);
            this.pnlConteudo.TabIndex = 1;
            // 
            // pbLogo
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCadastroGato;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCadastroTutor;
    }
}