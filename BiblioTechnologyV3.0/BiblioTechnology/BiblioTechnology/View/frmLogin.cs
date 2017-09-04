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
    public partial class frmLogin : Form
    {
        Bibliotecario biblio = new Bibliotecario();
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
       //     try
         //   {
           //     biblio.Login("", "");
            //}
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = biblio.Login(txtUsuario.Text, txtSenha.Text);
                if (nome != "")
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.toolstripBoasVindas.Text = "              Operador(a): "+nome;
                    principal.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("usuario ou senha Inválido");
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar o Banco de dados, \nO BiblioTechnology será reiniciado.", "ERRO BANCO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void lblEsqueciASenha_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha recuperarenha = new frmRecuperarSenha();
            recuperarenha.ShowDialog();
        }
    }
}
