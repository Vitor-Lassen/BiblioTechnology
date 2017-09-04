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
    public partial class frmBibliotecario : Form
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm ofrm = new OperacoesForm();
        Bibliotecario bibliotecario = new Bibliotecario();
        public bool consulta = false, estavaAtivo = false;
        public frmBibliotecario(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }

        public frmBibliotecario()
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsuBibliotecario consuBibliotecario = new frmConsuBibliotecario(this);
            ofrm.chamarFrm(contexto, consuBibliotecario);
            btnNovo_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if (txtNome.Text != "")
                {
                    if ((txtUsuario.Text != "") && (txtSenha.Text != ""))
                    {
                        if ((rbtnFeminino.Checked) || (rbtnMasculino.Checked))
                        {
                           
                            if ((txtEmail.Text != "")&&(txtEmail.Text.IndexOf("@")>0))
                            {
                                bool sexo;
                                if (rbtnFeminino.Checked)
                                {
                                    sexo = true;
                                }
                                else
                                {
                                    sexo = false;
                                }
                                if (consulta)
                                {
                                    bibliotecario.atuaBibliotecario(txtUsuario.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, sexo, chekAtivo.Checked);
                                }
                                else {

                                    bibliotecario.cadBibliotecario(txtUsuario.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, sexo, chekAtivo.Checked);
                                }
                                btnNovo_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Email inválido");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Selecione o sexo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos");
                    }

                }
                else
                {
                    MessageBox.Show("Digite o nome");
                }
            }
            catch
            {
                MessageBox.Show("nome de usuário já registrado, escolha outro");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar limpar = new Limpar();
            limpar.limpar(panel1);
            chekAtivo.Checked = true;
            consulta = false;
            txtUsuario.ReadOnly = false;
            estavaAtivo = false;
            btnSalvar.Text = "Cadastrar";

        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.bibliotecario;
        }

        private void rbtnFeminino_CheckedChanged(object sender, EventArgs e)
        {
            picImage.Image = Properties.Resources.bibliotecaria;
        }

        private void chekAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if ((consulta)&&(estavaAtivo==true))
            {
                if (chekAtivo.Checked == false)
                {
                    bool ativo = bibliotecario.consBibliotecariosAtivos();
                    if (ativo == false)
                    {
                        MessageBox.Show("Atualmente esse usuário é o unico ativo.");
                        chekAtivo.Checked = true;
                    }
                }
            }
        }
    }
}
