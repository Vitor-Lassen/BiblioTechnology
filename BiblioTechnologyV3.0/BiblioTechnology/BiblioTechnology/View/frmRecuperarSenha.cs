using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTechnology.Utilities;
using BiblioTechnology.DB;

namespace BiblioTechnology.View
{
    public partial class frmRecuperarSenha : Form
    {
        Email email = new Email();
        RecuperarSenha recuSen = new RecuperarSenha();
        string cod;
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void lblTemCod_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void btnProximo1_Click(object sender, EventArgs e)
        {

            txtCod.Focus();
            Random r = new Random();
            int valor = r.Next(1500, 2000);
            string data = DateTime.Now.ToShortDateString(), hora = DateTime.Now.ToShortTimeString();
            cod = data + hora + valor;

            if (recuSen.recuperarSenha1(txtEmail.Text, cod))
            {
                email.enviarEmail(txtEmail.Text, "Recuperação de senha, do BiblioTechnology", "Seu código de recuperação de senha é:\n\n                  " + cod + "\n\ncopie este código e cole no local indicado no sistema para prosseguir com a recuperação de senha\n\n BiblioTechnology");

                groupBox2.Visible = true;
            }
            else
            {
                MessageBox.Show( "Email não cadastrado! certifique-se o email foi digitado corretamente. ", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProximo2_Click(object sender, EventArgs e)
        {
            if (recuSen.recuperarSenha2(txtCod.Text))
            {
                groupBox3.Visible = true;
            }
            else
            {
                MessageBox.Show("Código Inválido, certifique que copiou o codigo corretamente.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if ((txtSenha.Text == txtConfirSenha.Text) && (lblAvisoSenha.Text == ""))
            {
                recuSen.recuperarSenha3(txtSenha.Text, txtCod.Text);
                MessageBox.Show("Senha alterada com sucesso!","");
                Close();
            }
            else
            {
                MessageBox.Show( "Senhas não conferem","");
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            txtCod.Text = txtCod.Text.Trim();
            txtCod.Select(txtCod.Text.Length, 0);


        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirSenha.Text)
            {
                lblAvisoSenha.Text = "As senhas não conferem";
            }
            else
            {
                lblAvisoSenha.Text = "";
            }
        }
    }
}
