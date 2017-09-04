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
    public partial class frmConsuBibliotecario : Form
    {
        Bibliotecario bibliotecario = new Bibliotecario();
        frmBibliotecario contextoBibliotecario = new frmBibliotecario();
        public frmConsuBibliotecario(frmBibliotecario contexto)
        {
            InitializeComponent();
            this.contextoBibliotecario = contexto;
        }

        private void frmConsuBibliotecario_Load(object sender, EventArgs e)
        {
            dgvBibliotecario.DataSource = bibliotecario.consBibliotecarioUsuario("").Tables[0];
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

            dgvBibliotecario.DataSource = bibliotecario.consBibliotecarioUsuario(txtUsuario.Text).Tables[0];

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
            dgvBibliotecario.DataSource = bibliotecario.consBibliotecarioNome(txtNome.Text).Tables[0];

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            
            contextoBibliotecario.txtUsuario.ReadOnly = true;
            
            contextoBibliotecario.btnSalvar.Text = "Salvar";
            string usuario = dgvBibliotecario.CurrentRow.Cells[0].Value.ToString();
            DataSet ds = new DataSet();
            ds = bibliotecario.consBibliotecarioDetalhes(usuario);
            contextoBibliotecario.txtUsuario.Text = usuario;
            contextoBibliotecario.txtSenha.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            contextoBibliotecario.txtNome.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            contextoBibliotecario.txtEmail.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            bool sexo = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[4].ToString());
            if (sexo)
            {
                contextoBibliotecario.rbtnFeminino.Checked = true;
            }
            else
            {
                contextoBibliotecario.rbtnMasculino.Checked = true;
            }
            contextoBibliotecario.chekAtivo.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[5].ToString());
            contextoBibliotecario.estavaAtivo = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[5].ToString());
            contextoBibliotecario.consulta = true;
            this.Close();
        }
    }
}
