namespace BiblioTechnology.View
{
    partial class frmRecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarSenha));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTemCod = new System.Windows.Forms.Label();
            this.btnProximo1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProximo2 = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAvisoSenha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblTemCod);
            this.groupBox1.Controls.Add(this.btnProximo1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passo 1";
            // 
            // lblTemCod
            // 
            this.lblTemCod.AutoSize = true;
            this.lblTemCod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTemCod.Location = new System.Drawing.Point(9, 70);
            this.lblTemCod.Name = "lblTemCod";
            this.lblTemCod.Size = new System.Drawing.Size(92, 13);
            this.lblTemCod.TabIndex = 3;
            this.lblTemCod.Text = "Já tenho o código";
            this.lblTemCod.Click += new System.EventHandler(this.lblTemCod_Click);
            // 
            // btnProximo1
            // 
            this.btnProximo1.Location = new System.Drawing.Point(350, 50);
            this.btnProximo1.Name = "btnProximo1";
            this.btnProximo1.Size = new System.Drawing.Size(75, 23);
            this.btnProximo1.TabIndex = 2;
            this.btnProximo1.Text = "Próximo";
            this.btnProximo1.UseVisualStyleBackColor = true;
            this.btnProximo1.Click += new System.EventHandler(this.btnProximo1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnProximo2);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passo 2";
            this.groupBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copie-o e cole-o aqui:";
            // 
            // btnProximo2
            // 
            this.btnProximo2.Location = new System.Drawing.Point(350, 84);
            this.btnProximo2.Name = "btnProximo2";
            this.btnProximo2.Size = new System.Drawing.Size(75, 23);
            this.btnProximo2.TabIndex = 2;
            this.btnProximo2.Text = "Próximo";
            this.btnProximo2.UseVisualStyleBackColor = true;
            this.btnProximo2.Click += new System.EventHandler(this.btnProximo2_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(142, 58);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(254, 20);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enviamos um e-mail com o código de recuperação.";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lblAvisoSenha);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtConfirSenha);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnConcluir);
            this.groupBox3.Controls.Add(this.txtSenha);
            this.groupBox3.Location = new System.Drawing.Point(11, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 108);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passo 3";
            this.groupBox3.Visible = false;
            // 
            // lblAvisoSenha
            // 
            this.lblAvisoSenha.AutoSize = true;
            this.lblAvisoSenha.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoSenha.Location = new System.Drawing.Point(153, 68);
            this.lblAvisoSenha.Name = "lblAvisoSenha";
            this.lblAvisoSenha.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoSenha.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Repita Senha:";
            // 
            // txtConfirSenha
            // 
            this.txtConfirSenha.Location = new System.Drawing.Point(156, 45);
            this.txtConfirSenha.Name = "txtConfirSenha";
            this.txtConfirSenha.PasswordChar = '✎';
            this.txtConfirSenha.Size = new System.Drawing.Size(149, 20);
            this.txtConfirSenha.TabIndex = 2;
            this.txtConfirSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nova senha:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(349, 71);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConcluir.TabIndex = 3;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(156, 19);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '✎';
            this.txtSenha.Size = new System.Drawing.Size(149, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(485, 410);
            this.Name = "frmRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Senha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTemCod;
        private System.Windows.Forms.Button btnProximo1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProximo2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblAvisoSenha;
    }
}