using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTechnology.View;
using BiblioTechnology.DB;

namespace BiblioTechnology.View
{
    public partial class frmGenero : Form
    {
        frmLivros contextoLivros = new frmLivros();
        Genero genero = new Genero();
        public frmGenero(frmLivros contexto)
        {
            InitializeComponent();
            contextoLivros = contexto;            
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            if (genero.consGeneroNome(txtGenero.Text).Tables[0].Rows.Count >= 1)
            {
                btnAdd.Visible = false;
            }
            else
            {
                btnAdd.Visible = true;
            }
            dgvGenero.DataSource = genero.consGenero(txtGenero.Text).Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            genero.cadGenero(txtGenero.Text);
            contextoLivros.recarregaCBOGenero();
            contextoLivros.cboGenero.Text = txtGenero.Text;
            
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            contextoLivros.cboGenero.Text = dgvGenero.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
