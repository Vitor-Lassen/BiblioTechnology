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
    public partial class frmLocatario : Form
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm ofrm = new OperacoesForm();
        Locatario locatario = new Locatario();
        public bool consulta = false;
        public int cod = 0;
        public frmLocatario(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;


        }

        public frmLocatario()
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsuLocatario consuAluno = new frmConsuLocatario(this);
            ofrm.chamarFrm(contexto, consuAluno);
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           if ((rdbAluno.Checked) || (rdbProfessor.Checked) || (rdbPublico.Checked) || rdbServidor.Checked)
           {
                if (txtNome.Text != "")
                {
                    if ((rdbFeminino.Checked) || (rdbMasculino.Checked))
                    {
                        int tipo = 0;
                        if (rdbAluno.Checked)
                        {
                            tipo = 1;
                        }
                        else if (rdbProfessor.Checked)
                        {
                            tipo = 2;
                        }
                        else if (rdbServidor.Checked)
                        {
                            tipo = 3;
                        }
                        else if (rdbPublico.Checked)
                        {
                            tipo = 4;
                        }
                        bool sexo = false;
                        if (rdbFeminino.Checked)
                        {
                            sexo = true;
                        }
                        else
                        {
                            sexo = false;
                        }
                        if (consulta)
                        {
                            locatario.atuaLocatario(cod, tipo, txtRM.Text, mskCPF.Text, txtNome.Text, sexo, cboTurma.Text, mskTel.Text, mskCel.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, cboBairro.Text, cboCidade.Text, mskCEP.Text, txtOBS.Text, chekAtivo.Checked);

                        }
                        else
                        {
                            locatario.cadLocatario(tipo, txtRM.Text, mskCPF.Text, txtNome.Text, sexo, cboTurma.Text, mskTel.Text, mskCel.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, cboBairro.Text, cboCidade.Text, mskCEP.Text, txtOBS.Text, chekAtivo.Checked);
                        }
                        btnNovo_Click(sender, e);
                        carregaCBOs();
                    }
                    else
                    {
                        MessageBox.Show("Selecione o sexo");
                    }
                }
                else
                {
                    MessageBox.Show("Digite o nome do locatário");
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo do locatário");
            }
        }
        private void mskCEP_Leave(object sender, EventArgs e)
        {
            try {
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
            limpar.limparRDB(groupBox1);
            chekAtivo.Checked = true;
            consulta = false;
            cod = 0;
            btnSalvar.Text = "Cadastrar";
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.Homem;
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.Mulher;

        }

        private void frmLocatario_Load(object sender, EventArgs e)
        {
            carregaCBOs();
        }
        private void carregaCBOs()
        {
            cboBairro.DataSource = locatario.consLocatariocboBairro().Tables[0];
            cboBairro.DisplayMember = "BAIRRO_LOC";
            cboBairro.SelectedIndex = -1;

            cboCidade.DataSource = locatario.consLocatariocboCidade().Tables[0];
            cboCidade.DisplayMember = "CIDADE_LOC";
            cboCidade.SelectedIndex = -1;

            cboTurma.DataSource = locatario.consLocatariocboTurma().Tables[0];
            cboTurma.DisplayMember = "TURMA_LOC";
            cboTurma.SelectedIndex = -1;
        }

        private void txtRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
