namespace BiblioTechnology.View
{
    partial class frmConsuLivro
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
            this.btnExpExcel = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.chekNaoAluga = new System.Windows.Forms.CheckBox();
            this.chekAlugados = new System.Windows.Forms.CheckBox();
            this.chekInativos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExpExcel);
            this.panel1.Controls.Add(this.btnDetalhes);
            this.panel1.Controls.Add(this.chekNaoAluga);
            this.panel1.Controls.Add(this.chekAlugados);
            this.panel1.Controls.Add(this.chekInativos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboGenero);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvLivros);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 407);
            this.panel1.TabIndex = 1;
            // 
            // btnExpExcel
            // 
            this.btnExpExcel.Location = new System.Drawing.Point(731, 83);
            this.btnExpExcel.Name = "btnExpExcel";
            this.btnExpExcel.Size = new System.Drawing.Size(75, 37);
            this.btnExpExcel.TabIndex = 13;
            this.btnExpExcel.Text = "Exportar Excel";
            this.btnExpExcel.UseVisualStyleBackColor = true;
            this.btnExpExcel.Click += new System.EventHandler(this.btnExpExcel_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(730, 379);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 12;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // chekNaoAluga
            // 
            this.chekNaoAluga.AutoSize = true;
            this.chekNaoAluga.Checked = true;
            this.chekNaoAluga.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chekNaoAluga.Location = new System.Drawing.Point(460, 94);
            this.chekNaoAluga.Name = "chekNaoAluga";
            this.chekNaoAluga.Size = new System.Drawing.Size(76, 17);
            this.chekNaoAluga.TabIndex = 11;
            this.chekNaoAluga.Text = "Não Aluga";
            this.chekNaoAluga.UseVisualStyleBackColor = true;
            this.chekNaoAluga.CheckedChanged += new System.EventHandler(this.verificaBusca);
            // 
            // chekAlugados
            // 
            this.chekAlugados.AutoSize = true;
            this.chekAlugados.Checked = true;
            this.chekAlugados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chekAlugados.Location = new System.Drawing.Point(542, 94);
            this.chekAlugados.Name = "chekAlugados";
            this.chekAlugados.Size = new System.Drawing.Size(70, 17);
            this.chekAlugados.TabIndex = 10;
            this.chekAlugados.Text = "Alugados";
            this.chekAlugados.UseVisualStyleBackColor = true;
            this.chekAlugados.CheckedChanged += new System.EventHandler(this.verificaBusca);
            // 
            // chekInativos
            // 
            this.chekInativos.AutoSize = true;
            this.chekInativos.Location = new System.Drawing.Point(624, 94);
            this.chekInativos.Name = "chekInativos";
            this.chekInativos.Size = new System.Drawing.Size(69, 17);
            this.chekInativos.TabIndex = 9;
            this.chekInativos.Text = "Inativos?";
            this.chekInativos.UseVisualStyleBackColor = true;
            this.chekInativos.CheckedChanged += new System.EventHandler(this.verificaBusca);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gênero:";
            // 
            // cboGenero
            // 
            this.cboGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(142, 92);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(157, 21);
            this.cboGenero.TabIndex = 7;
            this.cboGenero.TextChanged += new System.EventHandler(this.cboGenero_TextChanged);
            this.cboGenero.Enter += new System.EventHandler(this.enterLimpar);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(142, 66);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(551, 20);
            this.txtAutor.TabIndex = 6;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            this.txtAutor.Enter += new System.EventHandler(this.enterLimpar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(551, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.enterLimpar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(142, 14);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(118, 20);
            this.txtCod.TabIndex = 2;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.Enter += new System.EventHandler(this.enterLimpar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLivros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(3, 123);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(802, 250);
            this.dgvLivros.TabIndex = 0;
            this.dgvLivros.DoubleClick += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // frmConsuLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 431);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmConsuLivro";
            this.Text = "Consultar Livros ";
            this.Load += new System.EventHandler(this.frmConsuLivro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.CheckBox chekAlugados;
        private System.Windows.Forms.CheckBox chekInativos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chekNaoAluga;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnExpExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}