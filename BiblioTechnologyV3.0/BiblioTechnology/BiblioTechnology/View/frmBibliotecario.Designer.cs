namespace BiblioTechnology.View
{
    partial class frmBibliotecario
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label Label6;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label Label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chekAtivo = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(186, 167);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 13);
            label5.TabIndex = 50;
            label5.Text = "*Senha:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new System.Drawing.Point(192, 204);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(42, 13);
            Label6.TabIndex = 41;
            Label6.Text = "*E-mail:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(189, 93);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(42, 13);
            Label1.TabIndex = 32;
            Label1.Text = "*Nome:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(181, 130);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(50, 13);
            Label3.TabIndex = 28;
            Label3.Text = "*Usuário:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnFeminino);
            this.panel1.Controls.Add(this.rbtnMasculino);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chekAtivo);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(Label6);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(Label1);
            this.panel1.Controls.Add(Label3);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 321);
            this.panel1.TabIndex = 47;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(312, 54);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 4;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            this.rbtnFeminino.CheckedChanged += new System.EventHandler(this.rbtnFeminino_CheckedChanged);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(233, 54);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 2;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "*Sexo:";
            // 
            // chekAtivo
            // 
            this.chekAtivo.AutoSize = true;
            this.chekAtivo.Checked = true;
            this.chekAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chekAtivo.Location = new System.Drawing.Point(550, 245);
            this.chekAtivo.Name = "chekAtivo";
            this.chekAtivo.Size = new System.Drawing.Size(56, 17);
            this.chekAtivo.TabIndex = 14;
            this.chekAtivo.Text = "Ativo?";
            this.chekAtivo.UseVisualStyleBackColor = true;
            this.chekAtivo.CheckedChanged += new System.EventHandler(this.chekAtivo_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(233, 164);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '☻';
            this.txtSenha.Size = new System.Drawing.Size(146, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // picImage
            // 
            this.picImage.Image = global::BiblioTechnology.Properties.Resources.bibliotecario;
            this.picImage.Location = new System.Drawing.Point(3, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(170, 167);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 25;
            this.picImage.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Location = new System.Drawing.Point(15, 254);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 31);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovo.Location = new System.Drawing.Point(15, 217);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 31);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Location = new System.Drawing.Point(15, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 31);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(233, 127);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(233, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(373, 20);
            this.txtNome.TabIndex = 6;
            // 
            // frmBibliotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 351);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmBibliotecario";
            this.Text = "Bibliotecário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chekAtivo;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.RadioButton rbtnFeminino;
        public System.Windows.Forms.RadioButton rbtnMasculino;
        public System.Windows.Forms.Button btnSalvar;
    }
}