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
using BiblioTechnology.Utilities;

namespace BiblioTechnology.View
{
    public partial class frmEditora : Form
    {
        frmLivros contextoLivros = new frmLivros();
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm ofrm = new OperacoesForm();
        Editora editora = new Editora();

        public bool consulta = false;

        public frmEditora(frmLivros contextoLivros)
        {
            InitializeComponent();
            this.contextoLivros = contextoLivros;
            btnCancelar.Visible = true;
            btnConsultar.Visible = false;
        }
        public frmEditora(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }

        public frmEditora()
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsuEditora consuEditora = new frmConsuEditora(this);
            ofrm.chamarFrm(contexto, consuEditora);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (consulta)
                {
                    editora.atuaEditora(Convert.ToInt32(txtCod.Text), txtNome.Text, mskTel.Text, txtEmail.Text, txtSite.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, cboBairro.Text, cboCidade.Text, mskCEP.Text);

                }
                else
                {

                    editora.cadEditora(txtNome.Text, mskTel.Text, txtEmail.Text, txtSite.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, cboBairro.Text, cboCidade.Text, mskCEP.Text);
                }

                if (btnCancelar.Visible)
                {
                    contextoLivros.recarregaCBOEditora();
                    contextoLivros.cboEditora.Text = txtNome.Text;
                    this.Close();
                }
                else
                {
                    btnNovo_Click(sender, e);
                    carregaCBOs();
                }
            }
            else
            {
                MessageBox.Show("Digite o nome");
            }
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mskCEP.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);
                string msg = ds.Tables[0].Rows[0][1].ToString();
                if (msg == "sucesso - cep não encontrado")
                {
                    MessageBox.Show("CEP não encontrado!");
                }
                txtEndereco.Text = ds.Tables[0].Rows[0][6].ToString();
                cboBairro.Text = ds.Tables[0].Rows[0][4].ToString();
                cboCidade.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar.");
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar limpar = new Limpar();
            limpar.limpar(panel1);
            consulta = false;
            btnSalvar.Text = "Cadastrar";
        }

        private void frmEditora_Load(object sender, EventArgs e)
        {
            carregaCBOs();
        }
        private void carregaCBOs()
        {
            cboBairro.DataSource = editora.consEditoracboBairro().Tables[0];
            cboBairro.DisplayMember = "BAIRRO_EDIT";
            cboBairro.SelectedIndex = -1;

            cboCidade.DataSource = editora.consEditoracboCidade().Tables[0];
            cboCidade.DisplayMember = "CIDADE_EDIT";
            cboCidade.SelectedIndex = -1;
        }
    }
}
