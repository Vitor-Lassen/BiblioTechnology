using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTechnology.DB;

namespace BiblioTechnology.View
{
    public partial class frmTipoMaterial : Form
    {
        frmLivros contextoLivros = new frmLivros();
        TipoMaterial tipoMaterial = new TipoMaterial();
        public frmTipoMaterial(frmLivros contexto)
        {
            InitializeComponent();
            contextoLivros = contexto;
        }

        private void txtTipoMaterial_TextChanged(object sender, EventArgs e)
        {
            if (tipoMaterial.consTipoMaterialNome(txtTipoMaterial.Text).Tables[0].Rows.Count >= 1)
            {
                btnAdd.Visible = false;
            }
            else
            {
                btnAdd.Visible = true;
            }
            dgvTipoMaterial.DataSource = tipoMaterial.consTipoMaterial(txtTipoMaterial.Text).Tables[0];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tipoMaterial.cadTipoMaterial(txtTipoMaterial.Text);
            contextoLivros.recarregaCBOMaterial();
            contextoLivros.cboTipo.Text = txtTipoMaterial.Text;

            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            contextoLivros.cboTipo.Text = dgvTipoMaterial.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
