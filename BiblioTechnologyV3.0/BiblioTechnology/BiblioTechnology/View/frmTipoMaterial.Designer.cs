namespace BiblioTechnology.View
{
    partial class frmTipoMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoMaterial));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTipoMaterial = new System.Windows.Forms.DataGridView();
            this.txtTipoMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(287, 197);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(287, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTipoMaterial
            // 
            this.dgvTipoMaterial.AllowUserToAddRows = false;
            this.dgvTipoMaterial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvTipoMaterial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoMaterial.Location = new System.Drawing.Point(13, 41);
            this.dgvTipoMaterial.MultiSelect = false;
            this.dgvTipoMaterial.Name = "dgvTipoMaterial";
            this.dgvTipoMaterial.ReadOnly = true;
            this.dgvTipoMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoMaterial.Size = new System.Drawing.Size(349, 150);
            this.dgvTipoMaterial.TabIndex = 5;
            // 
            // txtTipoMaterial
            // 
            this.txtTipoMaterial.Location = new System.Drawing.Point(13, 14);
            this.txtTipoMaterial.Name = "txtTipoMaterial";
            this.txtTipoMaterial.Size = new System.Drawing.Size(268, 20);
            this.txtTipoMaterial.TabIndex = 4;
            this.txtTipoMaterial.TextChanged += new System.EventHandler(this.txtTipoMaterial_TextChanged);
            // 
            // frmTipoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 232);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTipoMaterial);
            this.Controls.Add(this.txtTipoMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 271);
            this.Name = "frmTipoMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo do Material";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTipoMaterial;
        private System.Windows.Forms.TextBox txtTipoMaterial;
    }
}