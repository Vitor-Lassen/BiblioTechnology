namespace BiblioTechnology.View
{
    partial class frmLivros
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
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label Label8;
            System.Windows.Forms.Label Label9;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivros));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboEditora = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTipo = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.chekAluga = new System.Windows.Forms.CheckBox();
            this.btnAddGenero = new System.Windows.Forms.Button();
            this.rtxtOBS = new System.Windows.Forms.RichTextBox();
            this.chekAtivo = new System.Windows.Forms.CheckBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.btnAddEditora = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Label7 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new System.Drawing.Point(424, 84);
            Label7.Name = "Label7";
            Label7.Size = new System.Drawing.Size(45, 13);
            Label7.TabIndex = 45;
            Label7.Text = "Gênero:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(175, 32);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(43, 13);
            Label2.TabIndex = 30;
            Label2.Text = "Código:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(180, 58);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(42, 13);
            Label3.TabIndex = 33;
            Label3.Text = "*Título:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(183, 84);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(35, 13);
            Label4.TabIndex = 36;
            Label4.Text = "Autor:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new System.Drawing.Point(175, 111);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(43, 13);
            Label5.TabIndex = 40;
            Label5.Text = "Editora:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new System.Drawing.Point(424, 111);
            Label8.Name = "Label8";
            Label8.Size = new System.Drawing.Size(43, 13);
            Label8.TabIndex = 42;
            Label8.Text = "Edição:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new System.Drawing.Point(440, 138);
            Label9.Name = "Label9";
            Label9.Size = new System.Drawing.Size(29, 13);
            Label9.TabIndex = 43;
            Label9.Text = "Ano:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(186, 184);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(32, 13);
            estadoLabel.TabIndex = 44;
            estadoLabel.Text = "OBS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(181, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 13);
            label1.TabIndex = 50;
            label1.Text = "Lugar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(183, 163);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(35, 13);
            label6.TabIndex = 56;
            label6.Text = "*Tipo:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Location = new System.Drawing.Point(15, 250);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 31);
            this.btnConsultar.TabIndex = 24;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovo.Location = new System.Drawing.Point(15, 213);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 31);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Location = new System.Drawing.Point(15, 176);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 31);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(224, 29);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(126, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(224, 55);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(381, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // cboAutor
            // 
            this.cboAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAutor.DisplayMember = "Autora";
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(224, 81);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(194, 21);
            this.cboAutor.TabIndex = 4;
            // 
            // cboEditora
            // 
            this.cboEditora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEditora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEditora.DisplayMember = "Editora";
            this.cboEditora.FormattingEnabled = true;
            this.cboEditora.Location = new System.Drawing.Point(224, 108);
            this.cboEditora.Name = "cboEditora";
            this.cboEditora.Size = new System.Drawing.Size(168, 21);
            this.cboEditora.TabIndex = 6;
            this.cboEditora.Validated += new System.EventHandler(this.cboEditora_Validated);
            // 
            // cboGenero
            // 
            this.cboGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGenero.DisplayMember = "Genero";
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(475, 81);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(104, 21);
            this.cboGenero.TabIndex = 12;
            this.cboGenero.Validated += new System.EventHandler(this.cboGenero_Validated);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(475, 108);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(130, 20);
            this.txtEdicao.TabIndex = 14;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(475, 135);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(130, 20);
            this.txtAno.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddTipo);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.chekAluga);
            this.panel1.Controls.Add(this.btnAddGenero);
            this.panel1.Controls.Add(this.rtxtOBS);
            this.panel1.Controls.Add(this.chekAtivo);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.txtLugar);
            this.panel1.Controls.Add(this.btnAddEditora);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.txtAno);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(Label9);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtEdicao);
            this.panel1.Controls.Add(Label8);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(Label5);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(Label4);
            this.panel1.Controls.Add(this.cboAutor);
            this.panel1.Controls.Add(Label3);
            this.panel1.Controls.Add(this.cboEditora);
            this.panel1.Controls.Add(Label2);
            this.panel1.Controls.Add(Label7);
            this.panel1.Controls.Add(this.cboGenero);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 300);
            this.panel1.TabIndex = 47;
            // 
            // btnAddTipo
            // 
            this.btnAddTipo.Location = new System.Drawing.Point(398, 160);
            this.btnAddTipo.Name = "btnAddTipo";
            this.btnAddTipo.Size = new System.Drawing.Size(20, 21);
            this.btnAddTipo.TabIndex = 57;
            this.btnAddTipo.TabStop = false;
            this.btnAddTipo.Text = "+";
            this.btnAddTipo.UseVisualStyleBackColor = true;
            this.btnAddTipo.Click += new System.EventHandler(this.btnAddTipo_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipo.DisplayMember = "Autora";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(224, 160);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(168, 21);
            this.cboTipo.TabIndex = 10;
            this.cboTipo.Validated += new System.EventHandler(this.cboTipo_Validated);
            // 
            // chekAluga
            // 
            this.chekAluga.AutoSize = true;
            this.chekAluga.Checked = true;
            this.chekAluga.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chekAluga.Location = new System.Drawing.Point(475, 161);
            this.chekAluga.Name = "chekAluga";
            this.chekAluga.Size = new System.Drawing.Size(59, 17);
            this.chekAluga.TabIndex = 54;
            this.chekAluga.Text = "Aluga?";
            this.chekAluga.UseVisualStyleBackColor = true;
            // 
            // btnAddGenero
            // 
            this.btnAddGenero.Location = new System.Drawing.Point(585, 81);
            this.btnAddGenero.Name = "btnAddGenero";
            this.btnAddGenero.Size = new System.Drawing.Size(20, 21);
            this.btnAddGenero.TabIndex = 53;
            this.btnAddGenero.TabStop = false;
            this.btnAddGenero.Text = "+";
            this.btnAddGenero.UseVisualStyleBackColor = true;
            this.btnAddGenero.Click += new System.EventHandler(this.btnAddGenero_Click);
            // 
            // rtxtOBS
            // 
            this.rtxtOBS.Location = new System.Drawing.Point(224, 184);
            this.rtxtOBS.Name = "rtxtOBS";
            this.rtxtOBS.Size = new System.Drawing.Size(381, 57);
            this.rtxtOBS.TabIndex = 18;
            this.rtxtOBS.Text = "";
            // 
            // chekAtivo
            // 
            this.chekAtivo.AutoSize = true;
            this.chekAtivo.Checked = true;
            this.chekAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chekAtivo.Location = new System.Drawing.Point(549, 161);
            this.chekAtivo.Name = "chekAtivo";
            this.chekAtivo.Size = new System.Drawing.Size(56, 17);
            this.chekAtivo.TabIndex = 51;
            this.chekAtivo.Text = "Ativo?";
            this.chekAtivo.UseVisualStyleBackColor = true;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(224, 135);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(194, 20);
            this.txtLugar.TabIndex = 8;
            // 
            // btnAddEditora
            // 
            this.btnAddEditora.Location = new System.Drawing.Point(398, 108);
            this.btnAddEditora.Name = "btnAddEditora";
            this.btnAddEditora.Size = new System.Drawing.Size(20, 21);
            this.btnAddEditora.TabIndex = 26;
            this.btnAddEditora.TabStop = false;
            this.btnAddEditora.Text = "+";
            this.btnAddEditora.UseVisualStyleBackColor = true;
            this.btnAddEditora.Click += new System.EventHandler(this.btnAddEditora_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 324);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLivros";
            this.Text = "Livro";
            this.Load += new System.EventHandler(this.frmLivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddEditora;
        public System.Windows.Forms.ComboBox cboEditora;
        private System.Windows.Forms.Button btnAddGenero;
        public System.Windows.Forms.ComboBox cboGenero;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.ComboBox cboAutor;
        public System.Windows.Forms.TextBox txtEdicao;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.RichTextBox rtxtOBS;
        public System.Windows.Forms.CheckBox chekAtivo;
        public System.Windows.Forms.TextBox txtLugar;
        public System.Windows.Forms.CheckBox chekAluga;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnAddTipo;
    }
}