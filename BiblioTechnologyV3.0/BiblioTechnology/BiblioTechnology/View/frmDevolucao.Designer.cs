namespace BiblioTechnology.View
{
    partial class frmDevolucao
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label Label6;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.dgvItensAlugados = new System.Windows.Forms.DataGridView();
            this.chekDevolver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCodLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbServidor = new System.Windows.Forms.RadioButton();
            this.rdbPublico = new System.Windows.Forms.RadioButton();
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNomeLocador = new System.Windows.Forms.ComboBox();
            this.txtCodLocador = new System.Windows.Forms.TextBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensAlugados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(112, 74);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 13);
            label8.TabIndex = 65;
            label8.Text = "CPF:";
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
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new System.Drawing.Point(27, 403);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(101, 13);
            Label5.TabIndex = 28;
            Label5.Text = "Data de devolução:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(Label5);
            this.panel1.Controls.Add(this.dtpDevolucao);
            this.panel1.Controls.Add(this.btnRenovar);
            this.panel1.Controls.Add(this.dgvItensAlugados);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDevolver);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 442);
            this.panel1.TabIndex = 0;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(134, 401);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(95, 20);
            this.dtpDevolucao.TabIndex = 24;
            this.dtpDevolucao.TabStop = false;
            // 
            // btnRenovar
            // 
            this.btnRenovar.Location = new System.Drawing.Point(235, 399);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(75, 23);
            this.btnRenovar.TabIndex = 27;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // dgvItensAlugados
            // 
            this.dgvItensAlugados.AllowUserToAddRows = false;
            this.dgvItensAlugados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvItensAlugados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItensAlugados.BackgroundColor = System.Drawing.Color.White;
            this.dgvItensAlugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensAlugados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chekDevolver,
            this.txtCodLivro,
            this.txtCod,
            this.txtAutor,
            this.txtDataLocacao,
            this.txtDataDevolucao,
            this.txtCodLocacao});
            this.dgvItensAlugados.Location = new System.Drawing.Point(23, 172);
            this.dgvItensAlugados.Name = "dgvItensAlugados";
            this.dgvItensAlugados.Size = new System.Drawing.Size(612, 220);
            this.dgvItensAlugados.TabIndex = 26;
            // 
            // chekDevolver
            // 
            this.chekDevolver.HeaderText = "";
            this.chekDevolver.Name = "chekDevolver";
            this.chekDevolver.Width = 25;
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.HeaderText = "Código";
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.ReadOnly = true;
            this.txtCodLivro.Width = 80;
            // 
            // txtCod
            // 
            this.txtCod.HeaderText = "Título";
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Width = 130;
            // 
            // txtAutor
            // 
            this.txtAutor.HeaderText = "Autor";
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Width = 130;
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.HeaderText = "Alugado";
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.ReadOnly = true;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.HeaderText = "Devolução";
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.ReadOnly = true;
            // 
            // txtCodLocacao
            // 
            this.txtCodLocacao.HeaderText = "CodLocacao";
            this.txtCodLocacao.Name = "txtCodLocacao";
            this.txtCodLocacao.ReadOnly = true;
            this.txtCodLocacao.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAviso);
            this.groupBox1.Controls.Add(this.mskCPF);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboNomeLocador);
            this.groupBox1.Controls.Add(this.txtCodLocador);
            this.groupBox1.Controls.Add(Label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 158);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locador";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(112, 90);
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
            this.groupBox3.Location = new System.Drawing.Point(112, 19);
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
            this.label1.Location = new System.Drawing.Point(209, 75);
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
            this.cboNomeLocador.Location = new System.Drawing.Point(212, 90);
            this.cboNomeLocador.Name = "cboNomeLocador";
            this.cboNomeLocador.Size = new System.Drawing.Size(390, 21);
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
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(550, 398);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 5;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(132, 132);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(38, 13);
            this.lblAviso.TabIndex = 66;
            this.lblAviso.Text = "Avisos";
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevolucao";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.atuaRdb);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensAlugados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rdbServidor;
        public System.Windows.Forms.RadioButton rdbPublico;
        public System.Windows.Forms.RadioButton rdbProfessor;
        public System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNomeLocador;
        private System.Windows.Forms.TextBox txtCodLocador;
        private System.Windows.Forms.DataGridView dgvItensAlugados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chekDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDataLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodLocacao;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label lblAviso;
    }
}