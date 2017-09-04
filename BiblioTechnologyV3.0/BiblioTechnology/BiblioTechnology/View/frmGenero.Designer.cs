namespace BiblioTechnology.View
{
    partial class frmGenero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenero));
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 12);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(268, 20);
            this.txtGenero.TabIndex = 0;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // dgvGenero
            // 
            this.dgvGenero.AllowUserToAddRows = false;
            this.dgvGenero.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvGenero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenero.BackgroundColor = System.Drawing.Color.White;
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Location = new System.Drawing.Point(12, 39);
            this.dgvGenero.MultiSelect = false;
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.ReadOnly = true;
            this.dgvGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenero.Size = new System.Drawing.Size(349, 150);
            this.dgvGenero.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(286, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(286, 195);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 232);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.txtGenero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 271);
            this.Name = "frmGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gênero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
    }
}