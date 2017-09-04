namespace BiblioTechnology.View
{
    partial class frmLocacao
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
            System.Windows.Forms.Label Label7;
            System.Windows.Forms.Label Label6;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbServidor = new System.Windows.Forms.RadioButton();
            this.rdbPublico = new System.Windows.Forms.RadioButton();
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNomeLocador = new System.Windows.Forms.ComboBox();
            this.txtCodLocador = new System.Windows.Forms.TextBox();
            this.dtpLocacao = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            Label7 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new System.Drawing.Point(6, 35);
            Label7.Name = "Label7";
            Label7.Size = new System.Drawing.Size(43, 13);
            Label7.TabIndex = 9;
            Label7.Text = "Código:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new System.Drawing.Point(12, 74);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(43, 13);
            Label6.TabIndex = 3;
            Label6.Text = "Código:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(17, 27);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(93, 13);
            Label4.TabIndex = 20;
            Label4.Text = "Data de Locação:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new System.Drawing.Point(208, 27);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(101, 13);
            Label5.TabIndex = 22;
            Label5.Text = "Data de devolução:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 113);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 13);
            label8.TabIndex = 65;
            label8.Text = "CPF:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAlugar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupbox);
            this.panel1.Controls.Add(Label4);
            this.panel1.Controls.Add(this.dtpLocacao);
            this.panel1.Controls.Add(Label5);
            this.panel1.Controls.Add(this.dtpDevolucao);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 370);
            this.panel1.TabIndex = 0;
            // 
            // btnAlugar
            // 
            this.btnAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.ForeColor = System.Drawing.Color.Red;
            this.btnAlugar.Location = new System.Drawing.Point(270, 320);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(148, 38);
            this.btnAlugar.TabIndex = 17;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = true;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodLivro);
            this.groupBox2.Controls.Add(Label7);
            this.groupBox2.Location = new System.Drawing.Point(20, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 98);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livro";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtAutor.Location = new System.Drawing.Point(96, 70);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(284, 20);
            this.txtAutor.TabIndex = 18;
            this.txtAutor.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Autor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(96, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(284, 20);
            this.txtTitulo.TabIndex = 17;
            this.txtTitulo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Título:";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(7, 51);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(84, 20);
            this.txtCodLivro.TabIndex = 0;
            this.txtCodLivro.TextChanged += new System.EventHandler(this.txtCodLivro_TextChanged);
            this.txtCodLivro.Leave += new System.EventHandler(this.txtCodLivro_Leave);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.mskCPF);
            this.groupbox.Controls.Add(label8);
            this.groupbox.Controls.Add(this.groupBox3);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.cboNomeLocador);
            this.groupbox.Controls.Add(this.txtCodLocador);
            this.groupbox.Controls.Add(Label6);
            this.groupbox.Location = new System.Drawing.Point(20, 49);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(398, 158);
            this.groupbox.TabIndex = 24;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Locador";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(12, 129);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(94, 20);
            this.mskCPF.TabIndex = 64;
            this.mskCPF.TextChanged += new System.EventHandler(this.mskCPF_TextChanged);
            this.mskCPF.Enter += new System.EventHandler(this.mskCPF_Enter);
            this.mskCPF.Leave += new System.EventHandler(this.mskCPF_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbServidor);
            this.groupBox3.Controls.Add(this.rdbPublico);
            this.groupBox3.Controls.Add(this.rdbProfessor);
            this.groupBox3.Controls.Add(this.rdbAluno);
            this.groupBox3.Location = new System.Drawing.Point(7, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 50);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // rdbServidor
            // 
            this.rdbServidor.AutoSize = true;
            this.rdbServidor.Location = new System.Drawing.Point(202, 19);
            this.rdbServidor.Name = "rdbServidor";
            this.rdbServidor.Size = new System.Drawing.Size(75, 17);
            this.rdbServidor.TabIndex = 4;
            this.rdbServidor.Text = "Servidores";
            this.rdbServidor.UseVisualStyleBackColor = true;
            this.rdbServidor.CheckedChanged += new System.EventHandler(this.atuaRdb);
            // 
            // rdbPublico
            // 
            this.rdbPublico.AutoSize = true;
            this.rdbPublico.Location = new System.Drawing.Point(309, 18);
            this.rdbPublico.Name = "rdbPublico";
            this.rdbPublico.Size = new System.Drawing.Size(60, 17);
            this.rdbPublico.TabIndex = 6;
            this.rdbPublico.Text = "Público";
            this.rdbPublico.UseVisualStyleBackColor = true;
            this.rdbPublico.CheckedChanged += new System.EventHandler(this.atuaRdb);
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.AutoSize = true;
            this.rdbProfessor.Location = new System.Drawing.Point(90, 19);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Size = new System.Drawing.Size(80, 17);
            this.rdbProfessor.TabIndex = 2;
            this.rdbProfessor.Text = "Professores";
            this.rdbProfessor.UseVisualStyleBackColor = true;
            this.rdbProfessor.CheckedChanged += new System.EventHandler(this.atuaRdb);
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
            this.rdbAluno.CheckedChanged += new System.EventHandler(this.atuaRdb);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // cboNomeLocador
            // 
            this.cboNomeLocador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNomeLocador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNomeLocador.DisplayMember = "Nome";
            this.cboNomeLocador.FormattingEnabled = true;
            this.cboNomeLocador.Location = new System.Drawing.Point(112, 90);
            this.cboNomeLocador.Name = "cboNomeLocador";
            this.cboNomeLocador.Size = new System.Drawing.Size(274, 21);
            this.cboNomeLocador.TabIndex = 1;
            this.cboNomeLocador.ValueMember = "Código do Locador";
            this.cboNomeLocador.SelectedIndexChanged += new System.EventHandler(this.cboNomeLocador_SelectedIndexChanged);
            this.cboNomeLocador.Enter += new System.EventHandler(this.cboNomeLocador_Enter);
            this.cboNomeLocador.Leave += new System.EventHandler(this.cboNomeLocador_Leave);
            // 
            // txtCodLocador
            // 
            this.txtCodLocador.Location = new System.Drawing.Point(12, 90);
            this.txtCodLocador.Name = "txtCodLocador";
            this.txtCodLocador.Size = new System.Drawing.Size(94, 20);
            this.txtCodLocador.TabIndex = 0;
            this.txtCodLocador.TextChanged += new System.EventHandler(this.txtCodLocador_TextChanged);
            this.txtCodLocador.Enter += new System.EventHandler(this.txtCodLocador_Enter);
            this.txtCodLocador.Leave += new System.EventHandler(this.txtCodLocador_Leave);
            // 
            // dtpLocacao
            // 
            this.dtpLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLocacao.Location = new System.Drawing.Point(110, 24);
            this.dtpLocacao.Name = "dtpLocacao";
            this.dtpLocacao.Size = new System.Drawing.Size(95, 20);
            this.dtpLocacao.TabIndex = 21;
            this.dtpLocacao.TabStop = false;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(311, 24);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(95, 20);
            this.dtpDevolucao.TabIndex = 23;
            this.dtpDevolucao.TabStop = false;
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 392);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocacao";
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.atuaRdb);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNomeLocador;
        private System.Windows.Forms.TextBox txtCodLocador;
        private System.Windows.Forms.DateTimePicker dtpLocacao;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rdbServidor;
        public System.Windows.Forms.RadioButton rdbPublico;
        public System.Windows.Forms.RadioButton rdbProfessor;
        public System.Windows.Forms.RadioButton rdbAluno;
        public System.Windows.Forms.MaskedTextBox mskCPF;
    }
}