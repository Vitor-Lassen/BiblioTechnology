namespace BiblioTechnology.View
{
    partial class frmConsuLocatario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbServidor = new System.Windows.Forms.RadioButton();
            this.rdbPublico = new System.Windows.Forms.RadioButton();
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocatario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDetalhes);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.mskCPF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTurma);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvLocatario);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 378);
            this.panel1.TabIndex = 0;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(555, 347);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 67;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbServidor);
            this.groupBox1.Controls.Add(this.rdbPublico);
            this.groupBox1.Controls.Add(this.rdbProfessor);
            this.groupBox1.Controls.Add(this.rdbAluno);
            this.groupBox1.Location = new System.Drawing.Point(125, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 50);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdbServidor
            // 
            this.rdbServidor.AutoSize = true;
            this.rdbServidor.Location = new System.Drawing.Point(202, 19);
            this.rdbServidor.Name = "rdbServidor";
            this.rdbServidor.Size = new System.Drawing.Size(75, 17);
            this.rdbServidor.TabIndex = 3;
            this.rdbServidor.Text = "Servidores";
            this.rdbServidor.UseVisualStyleBackColor = true;
            this.rdbServidor.CheckedChanged += new System.EventHandler(this.atuaTipo);
            // 
            // rdbPublico
            // 
            this.rdbPublico.AutoSize = true;
            this.rdbPublico.Location = new System.Drawing.Point(309, 18);
            this.rdbPublico.Name = "rdbPublico";
            this.rdbPublico.Size = new System.Drawing.Size(60, 17);
            this.rdbPublico.TabIndex = 2;
            this.rdbPublico.Text = "Público";
            this.rdbPublico.UseVisualStyleBackColor = true;
            this.rdbPublico.CheckedChanged += new System.EventHandler(this.atuaTipo);
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.AutoSize = true;
            this.rdbProfessor.Location = new System.Drawing.Point(90, 19);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Size = new System.Drawing.Size(80, 17);
            this.rdbProfessor.TabIndex = 1;
            this.rdbProfessor.Text = "Professores";
            this.rdbProfessor.UseVisualStyleBackColor = true;
            this.rdbProfessor.CheckedChanged += new System.EventHandler(this.atuaTipo);
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Checked = true;
            this.rdbAluno.Location = new System.Drawing.Point(6, 19);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(52, 17);
            this.rdbAluno.TabIndex = 0;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            this.rdbAluno.CheckedChanged += new System.EventHandler(this.atuaTipo);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(223, 66);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 65;
            this.mskCPF.TextChanged += new System.EventHandler(this.mskCPF_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "CPF:";
            // 
            // cboTurma
            // 
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Location = new System.Drawing.Point(497, 66);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(113, 21);
            this.cboTurma.TabIndex = 6;
            this.cboTurma.TextChanged += new System.EventHandler(this.cboTurma_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turma:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(551, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(59, 66);
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(118, 20);
            this.txtRM.TabIndex = 2;
            this.txtRM.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RM:";
            // 
            // dgvLocatario
            // 
            this.dgvLocatario.AllowUserToAddRows = false;
            this.dgvLocatario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLocatario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocatario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocatario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLocatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocatario.Location = new System.Drawing.Point(3, 134);
            this.dgvLocatario.Name = "dgvLocatario";
            this.dgvLocatario.ReadOnly = true;
            this.dgvLocatario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocatario.Size = new System.Drawing.Size(627, 207);
            this.dgvLocatario.TabIndex = 0;
            this.dgvLocatario.DoubleClick += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // frmConsuLocatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmConsuLocatario";
            this.Text = "Consultar Locatários";
            this.Load += new System.EventHandler(this.atuaTipo);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLocatario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdbServidor;
        public System.Windows.Forms.RadioButton rdbPublico;
        public System.Windows.Forms.RadioButton rdbProfessor;
        public System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.Button btnDetalhes;
    }
}