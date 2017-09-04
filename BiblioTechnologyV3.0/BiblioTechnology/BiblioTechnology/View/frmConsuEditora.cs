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
    public partial class frmConsuEditora : Form
    {
        Editora editora = new Editora();
        frmEditora contextoEditora = new frmEditora();
        public frmConsuEditora(frmEditora contexto)
        {
            InitializeComponent();
            contextoEditora = contexto;
            dgvEditora.DataSource = editora.consEditoraNome("").Tables[0];

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(dgvEditora.CurrentRow.Cells[0].Value.ToString());
            DataSet ds = new DataSet();
            ds = editora.consEditoraDetalhes(cod);
            contextoEditora.txtCod.Text = cod.ToString();
            contextoEditora.txtNome.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            contextoEditora.mskTel.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            contextoEditora.txtEmail.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            contextoEditora.txtSite.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            contextoEditora.txtEndereco.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            contextoEditora.txtNumero.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            contextoEditora.txtComplemento.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            contextoEditora.cboBairro.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            contextoEditora.cboCidade.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
            contextoEditora.mskCEP.Text = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            contextoEditora.consulta = true;
            contextoEditora.btnSalvar.Text = "Salvar";
            this.Close();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            dgvEditora.DataSource = editora.consEditoraNome(txtNome.Text).Tables[0];
        }
    }
}
