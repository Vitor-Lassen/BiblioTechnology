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
    public partial class frmConsuLocatario : Form
    {
        Locatario locatario = new Locatario();
        frmLocatario contextoLocatario = new frmLocatario();
        int tipo;
        public frmConsuLocatario(frmLocatario contexto)
        {
            InitializeComponent();
            contextoLocatario = contexto;
        }
      
        

        private void atuaTipo(object sender, EventArgs e)
        {
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
            dgvLocatario.DataSource = locatario.consLocatarioNome("", tipo).Tables[0];
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            dgvLocatario.DataSource = locatario.consLocatarioNome(txtNome.Text, tipo).Tables[0];
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvLocatario.DataSource = locatario.consLocatarioRM(txtRM.Text, tipo).Tables[0];

            }
            catch
            {
            }
        }

        private void cboTurma_TextChanged(object sender, EventArgs e)
        {
            dgvLocatario.DataSource = locatario.consLocatarioTurma(cboTurma.Text, tipo).Tables[0];
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            dgvLocatario.DataSource = locatario.consLocatarioCPF(mskCPF.Text, tipo).Tables[0];
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            contextoLocatario.consulta = true;
            int cod = Convert.ToInt32(dgvLocatario.CurrentRow.Cells[0].Value.ToString());
            DataSet ds = new DataSet();
            ds = locatario.consLocatarioDetalhes(cod);
            contextoLocatario.cod = cod;
            int tipo = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[1].ToString());
            if (tipo == 1)
            {
                contextoLocatario.rdbAluno.Checked = true;
            }
            else if (tipo == 2)
            {
                contextoLocatario.rdbProfessor.Checked = true;
            }
            else if (tipo == 3)
            {
                contextoLocatario.rdbServidor.Checked = true;
            }
            else if (tipo == 4)
            {
                contextoLocatario.rdbPublico.Checked = true;
            }
            contextoLocatario.txtRM.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            contextoLocatario.mskCPF.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            contextoLocatario.txtNome.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            bool sexo = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[5].ToString());
            if (sexo)
            {
                contextoLocatario.rdbFeminino.Checked = true;
            }
            else
            {
                contextoLocatario.rdbMasculino.Checked = true;
            }
            contextoLocatario.cboTurma.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            contextoLocatario.mskTel.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            contextoLocatario.mskCel.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            contextoLocatario.txtEndereco.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
            contextoLocatario.txtNumero.Text = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            contextoLocatario.txtComplemento.Text = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            contextoLocatario.cboBairro.Text = ds.Tables[0].Rows[0].ItemArray[12].ToString();
            contextoLocatario.cboCidade.Text = ds.Tables[0].Rows[0].ItemArray[13].ToString();
            contextoLocatario.mskCEP.Text = ds.Tables[0].Rows[0].ItemArray[14].ToString();
            contextoLocatario.txtOBS.Text = ds.Tables[0].Rows[0].ItemArray[15].ToString();
            contextoLocatario.chekAtivo.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[16].ToString());
            contextoLocatario.btnSalvar.Text = "Salvar";
            Close();
        }
    }
}
