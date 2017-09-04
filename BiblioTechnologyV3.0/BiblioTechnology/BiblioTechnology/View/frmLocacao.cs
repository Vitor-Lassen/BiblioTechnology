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
    public partial class frmLocacao : Form
    {
        Livro livro = new Livro();
        Config config = new Config();
        Locatario locatario = new Locatario();
        Locacao locacao = new Locacao();
        Limpar limpar = new Limpar();
        int tipo = 0, codLoc = 0, qtdMaxLivros;
        bool aluga = true, focoCOD = false, focoNome = false, focoCPF = false;

        public frmLocacao()
        {
            InitializeComponent();

        }

        private void atuaRdb(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = config.consConfig();

            if (rdbAluno.Checked)
            {
                dtpDevolucao.Text = DateTime.Now.AddDays(Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[1].ToString())).ToString();
                tipo = 1;
            }
            else if (rdbProfessor.Checked)
            {
                dtpDevolucao.Text = DateTime.Now.AddDays(Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[2].ToString())).ToString();
                tipo = 2;
            }
            else if (rdbServidor.Checked)
            {
                dtpDevolucao.Text = DateTime.Now.AddDays(Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[3].ToString())).ToString();
                tipo = 3;
            }
            else
            {
                tipo = 4;
                dtpDevolucao.Text = DateTime.Now.AddDays(Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[4].ToString())).ToString();
            }
            qtdMaxLivros = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[4 + tipo].ToString());
            cboNomeLocador.DataSource = locatario.consLocatarioNome("", tipo).Tables[0];
            cboNomeLocador.DisplayMember = "Nome";
            cboNomeLocador.Text = "";
            txtCodLocador.Clear();
            mskCPF.Text = "";
            codLoc = 0;
        }
        
        private void txtCodLivro_TextChanged(object sender, EventArgs e)
       {
            
            txtAutor.Clear();
            txtTitulo.Clear();
            try
            {
                DataSet ds = new DataSet();
                ds = livro.consLivroCodigo(Convert.ToInt32(txtCodLivro.Text));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[6].ToString()) == false)
                    {
                        aluga = false;
                    }
                    
                        txtTitulo.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        txtAutor.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    
                }
               
            }
            catch { }
        }

        private void txtCodLocador_TextChanged(object sender, EventArgs e)
        {
            if (focoCOD)
            {
                mskCPF.Clear();
                cboNomeLocador.SelectedIndex = -1;
                try
                {
                    DataSet ds = new DataSet();
                    ds = locatario.consLocacaoRM(txtCodLocador.Text, tipo);
                    cboNomeLocador.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                    mskCPF.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                }
                catch
                {
                    cboNomeLocador.Text = "";
                    mskCPF.Text = "";
                    codLoc = 0;
                }
            }
        }

        private void txtCodLocador_Enter(object sender, EventArgs e)
        {
            focoCOD = true;
        }

        private void txtCodLocador_Leave(object sender, EventArgs e)
        {
            focoCOD = false;
        }

        private void cboNomeLocador_Enter(object sender, EventArgs e)
        {
            focoNome = true;
        }

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            focoCPF = false;
        }

        private void mskCPF_Enter(object sender, EventArgs e)
        {
            focoCPF = true;
        }

        private void cboNomeLocador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (focoNome)
            {
                mskCPF.Clear();
                txtCodLocador.Clear();
                try
                {

                    DataSet ds = new DataSet();
                    ds = locatario.consLocacaoNome(cboNomeLocador.Text, tipo);
                    txtCodLocador.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    mskCPF.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                }
                catch
                {
                    txtCodLocador.Clear();
                    mskCPF.Text = "";
                    codLoc = 0;
                }
            }
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            if (focoCPF)
            {
                cboNomeLocador.SelectedIndex = -1;
                txtCodLocador.Clear();
                try
                {
                    DataSet ds = new DataSet();
                    ds = locatario.consLocacaoCPF(mskCPF.Text, tipo);
                    txtCodLocador.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    cboNomeLocador.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                    codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                }
                catch
                {
                    txtCodLocador.Clear();
                    cboNomeLocador.Text = "";
                    codLoc = 0;
                }
            }
        }

        private void txtCodLivro_Leave(object sender, EventArgs e)
        {
            if (aluga == false)
            {
                MessageBox.Show("Esse Material não pode ser Alugado");
                txtCodLivro.Clear();
                aluga = true;
            }
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            if (codLoc != 0)
            {
                if((txtAutor.Text!= "")||(txtTitulo.Text != ""))
                {
                    if (locatario.consLocatarioAtivo(codLoc))
                    {
                        if (locacao.consQTDLivrosAlugadosLoc(codLoc) < qtdMaxLivros)
                        {
                            locacao.cadLocacao(codLoc, Convert.ToInt32(txtCodLivro.Text), dtpLocacao.Value, dtpDevolucao.Value);
                            limpar.limpar(groupBox2);
                            limpar.limpar(groupbox);
                        }
                        else
                        {
                            MessageBox.Show("Locatário já esta com a quantidade máxima de materias emprestados da Biblioteca.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Locatário Bloqueado!");
                    }

                }
                else 
                {
                    MessageBox.Show("Selecione o Livro");
                }
            }
            else
            {
                MessageBox.Show("Selecione o Locatário");
            }
        }

        private void cboNomeLocador_Leave(object sender, EventArgs e)
        {
            focoNome = false;
            if (locatario.consLocacaoNome(cboNomeLocador.Text, tipo).Tables[0].Rows.Count <= 0)
            {
                txtCodLocador.Clear();
                mskCPF.Text = "";
                cboNomeLocador.Text = "";
                codLoc = 0;
            }
        }
    }
}