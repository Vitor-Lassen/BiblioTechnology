namespace BiblioTechnology.View
{
    partial class frmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDevolucoesPendentes = new System.Windows.Forms.DataGridView();
            this.dgvDevolucoesAtraso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDataPendentes = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExpExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoesPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoesAtraso)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevolucoesPendentes
            // 
            this.dgvDevolucoesPendentes.AllowUserToAddRows = false;
            this.dgvDevolucoesPendentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDevolucoesPendentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevolucoesPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolucoesPendentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevolucoesPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucoesPendentes.Location = new System.Drawing.Point(14, 58);
            this.dgvDevolucoesPendentes.MultiSelect = false;
            this.dgvDevolucoesPendentes.Name = "dgvDevolucoesPendentes";
            this.dgvDevolucoesPendentes.ReadOnly = true;
            this.dgvDevolucoesPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucoesPendentes.Size = new System.Drawing.Size(631, 211);
            this.dgvDevolucoesPendentes.TabIndex = 0;
            this.dgvDevolucoesPendentes.DoubleClick += new System.EventHandler(this.dgvDevolucoesPendentes_DoubleClick);
            // 
            // dgvDevolucoesAtraso
            // 
            this.dgvDevolucoesAtraso.AllowUserToAddRows = false;
            this.dgvDevolucoesAtraso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDevolucoesAtraso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevolucoesAtraso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolucoesAtraso.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevolucoesAtraso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucoesAtraso.Location = new System.Drawing.Point(14, 312);
            this.dgvDevolucoesAtraso.MultiSelect = false;
            this.dgvDevolucoesAtraso.Name = "dgvDevolucoesAtraso";
            this.dgvDevolucoesAtraso.ReadOnly = true;
            this.dgvDevolucoesAtraso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucoesAtraso.Size = new System.Drawing.Size(631, 160);
            this.dgvDevolucoesAtraso.TabIndex = 1;
            this.dgvDevolucoesAtraso.DoubleClick += new System.EventHandler(this.dgvDevolucoesAtraso_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devoluções esperadas no dia:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(163, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(111, 20);
            this.dtpData.TabIndex = 3;
            this.dtpData.ValueChanged += new System.EventHandler(this.frmHome_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Devoluções Pendentes até:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDataPendentes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnExpExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvDevolucoesPendentes);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.dgvDevolucoesAtraso);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 525);
            this.panel1.TabIndex = 5;
            // 
            // dtpDataPendentes
            // 
            this.dtpDataPendentes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPendentes.Location = new System.Drawing.Point(163, 284);
            this.dtpDataPendentes.Name = "dtpDataPendentes";
            this.dtpDataPendentes.Size = new System.Drawing.Size(111, 20);
            this.dtpDataPendentes.TabIndex = 17;
            this.dtpDataPendentes.ValueChanged += new System.EventHandler(this.frmHome_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Desenvolvido por Vitor Lassen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Produto Licenciado para: Avaliação";
            // 
            // btnExpExcel
            // 
            this.btnExpExcel.Location = new System.Drawing.Point(557, 286);
            this.btnExpExcel.Name = "btnExpExcel";
            this.btnExpExcel.Size = new System.Drawing.Size(88, 25);
            this.btnExpExcel.TabIndex = 14;
            this.btnExpExcel.Text = "Exportar Excel";
            this.btnExpExcel.UseVisualStyleBackColor = true;
            this.btnExpExcel.Click += new System.EventHandler(this.btnExpExcel_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 549);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoesPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoesAtraso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevolucoesPendentes;
        private System.Windows.Forms.DataGridView dgvDevolucoesAtraso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExpExcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataPendentes;
    }
}