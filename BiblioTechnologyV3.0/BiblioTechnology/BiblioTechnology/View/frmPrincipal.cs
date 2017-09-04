using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiblioTechnology.View;


namespace BiblioTechnology
{
    public partial class frmPrincipal : Form
    {
        
        
        OperacoesForm ofrm = new OperacoesForm();
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
        }
        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }
        private void locatariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmLocatario locatarios = new frmLocatario(this);
            ofrm.chamarFrm(this, locatarios);

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmLivros livros = new frmLivros(this);
            ofrm.chamarFrm(this, livros);
            
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmLocacao locacao = new frmLocacao();
            ofrm.chamarFrm(this, locacao);
           
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmDevolucao devolucao = new frmDevolucao();
            ofrm.chamarFrm(this, devolucao);
            

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmHome home = new frmHome(this);
            ofrm.chamarFrm(this, home);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            homeToolStripMenuItem_Click(sender, e);
        }

      

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmEditora editora = new frmEditora(this);
            ofrm.chamarFrm(this, editora);
        }

        private void bibliotecarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmBibliotecario bibliotecario = new frmBibliotecario(this);
            ofrm.chamarFrm(this, bibliotecario);
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilities.Backup backup = new Utilities.Backup();
            backup.backup(saveFileDialog);
        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.Backup backup = new Utilities.Backup();
            backup.restauraBackup(openFileDialog);
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmConfig config = new frmConfig();
            ofrm.chamarFrm(this, config);
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmMovimentacao movimentacao = new frmMovimentacao();
            ofrm.chamarFrm(this, movimentacao);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frmSobre sobre = new frmSobre();
            ofrm.chamarFrm(this, sobre);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
