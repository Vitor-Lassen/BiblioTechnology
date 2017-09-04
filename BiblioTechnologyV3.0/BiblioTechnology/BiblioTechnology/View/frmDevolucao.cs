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
    public partial class frmDevolucao : Form
    {
        Locatario locatario = new Locatario();
        Locacao locacao = new Locacao();
        Livro livro = new Livro();
        Limpar limpar = new Limpar();
        Config config = new Config();
        int tipo = 0, codLoc = 0;
        bool ativoCodLoc = false, ativoMskCPF = false, ativoCboNome = false;
        public frmDevolucao()
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
           // qtdMaxLivros = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[4 + tipo].ToString());
            cboNomeLocador.DataSource = locatario.consLocatarioNome("", tipo).Tables[0];
            cboNomeLocador.DisplayMember = "Nome";
            cboNomeLocador.Text = "";
            txtCodLocador.Clear();
            mskCPF.Text = "";
            lblAviso.Text = "";
            codLoc = 0;
            limpar.limparDGV(dgvItensAlugados);
        }
        private void buscaLivrosAlugados()
        {
            if (codLoc != 0)
            {
                limpar.limparDGV(dgvItensAlugados);
                DataSet dsLocacao = new DataSet();
                dsLocacao = locacao.consLivrosAlugadosLoc(codLoc);
                for (int i = 0; i < dsLocacao.Tables[0].Rows.Count; i++)
                {
                    DataSet dsLivros = new DataSet();
                    dsLivros = livro.consLivroCodigo(Convert.ToInt32(dsLocacao.Tables[0].Rows[i].ItemArray[2].ToString()));
                    dgvItensAlugados.Rows.Add(false, dsLocacao.Tables[0].Rows[i].ItemArray[2].ToString(),dsLivros.Tables[0].Rows[0].ItemArray[1].ToString(), 
                    dsLivros.Tables[0].Rows[0].ItemArray[2].ToString(), dsLocacao.Tables[0].Rows[i].ItemArray[3].ToString().Split(' ').First(), 
                    dsLocacao.Tables[0].Rows[i].ItemArray[4].ToString().Split(' ').First(), dsLocacao.Tables[0].Rows[i].ItemArray[0].ToString());

                }
                if (dsLocacao.Tables[0].Rows.Count <= 0)
                {
                    lblAviso.Text =  cboNomeLocador.Text + " Não possui livros alugados!";
                }
                else
                {
                    lblAviso.Text = "";
                }
            }
        }
        public void buscaLocCod(int cod, int tipo)
        {
            if (tipo == 1)
            {
                rdbAluno.Checked = true;
            }
            else if (tipo == 2)
            {
                rdbProfessor.Checked = true;
            }
            else if (tipo == 3)
            {
                rdbServidor.Checked = true;
            }
            else 
            {
                rdbPublico.Checked = true;
            }
            DataSet ds = new DataSet();
            ds = locatario.consLocacaoCod(cod);
            cboNomeLocador.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            mskCPF.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            txtCodLocador.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            buscaLivrosAlugados();
        }

        private void txtCodLocador_TextChanged(object sender, EventArgs e)
        {
            if (ativoCodLoc)
            {
               
                    try
                    {
                        DataSet ds = new DataSet();
                        ds = locatario.consLocacaoRM(txtCodLocador.Text, tipo);
                        cboNomeLocador.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                        mskCPF.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                        buscaLivrosAlugados();

                    }
                    catch
                    {
                        cboNomeLocador.Text = "";
                        mskCPF.Text = "";
                        codLoc = 0;
                        limpar.limparDGV(dgvItensAlugados);
                    }
                
            }
        }

        private void cboNomeLocador_Enter(object sender, EventArgs e)
        {
            ativoCboNome = true;
        }

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            ativoMskCPF = false;
        }

        private void mskCPF_Enter(object sender, EventArgs e)
        {
            ativoMskCPF = true;
        }

        private void txtCodLocador_Leave(object sender, EventArgs e)
        {
            ativoCodLoc = false;
        }

        private void txtCodLocador_Enter(object sender, EventArgs e)
        {
            ativoCodLoc = true;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int qtdLivros = 0;
            for (int i = 0; i< dgvItensAlugados.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvItensAlugados.Rows[i].Cells[0].Value.ToString()))
                {
                    locacao.devolucao(Convert.ToInt32(dgvItensAlugados.Rows[i].Cells[6].Value.ToString()), DateTime.Now,
                        Convert.ToInt32(dgvItensAlugados.Rows[i].Cells[1].Value.ToString()));
                    qtdLivros += 1;
                }
            }
            if(qtdLivros != 0)
            {
                MessageBox.Show(qtdLivros.ToString() + " Livros devolvidos com sucesso!");
                buscaLivrosAlugados();
            }
            
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            string livrosRenovados = "";
            for (int i = 0; i < dgvItensAlugados.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvItensAlugados.Rows[i].Cells[0].Value.ToString()))
                {
                    locacao.renovacao(Convert.ToInt32(dgvItensAlugados.Rows[i].Cells[6].Value.ToString()), dtpDevolucao.Value, Convert.ToInt32(dgvItensAlugados.Rows[i].Cells[1].Value.ToString()));
                    livrosRenovados += dgvItensAlugados.Rows[i].Cells[2].Value.ToString() +"\n";
                }
            }
            if (livrosRenovados != "")
            {
                MessageBox.Show("Livros Renonovados:"+livrosRenovados);
                buscaLivrosAlugados();
            }
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            if (ativoMskCPF)
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds = locatario.consLocacaoCPF(mskCPF.Text, tipo);
                    txtCodLocador.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    cboNomeLocador.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                    codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    buscaLivrosAlugados();
                    
                }
                catch
                {
                    txtCodLocador.Clear();
                    cboNomeLocador.Text = "";
                    codLoc = 0;
                    limpar.limparDGV(dgvItensAlugados);
                }
            }

        }

        private void cboNomeLocador_Leave(object sender, EventArgs e)
        {
            if (locatario.consLocacaoNome(cboNomeLocador.Text, tipo).Tables[0].Rows.Count <= 0)
            {
                txtCodLocador.Clear();
                mskCPF.Text = "";
                cboNomeLocador.Text = "";
                codLoc = 0;
                ativoCboNome = false;
            }
        }

        private void cboNomeLocador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ativoCboNome)
            {
                try
                {

                    DataSet ds = new DataSet();
                    ds = locatario.consLocacaoNome(cboNomeLocador.Text, tipo);
                    txtCodLocador.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    mskCPF.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    codLoc = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    buscaLivrosAlugados();
                    
                }
                catch
                {
                    txtCodLocador.Clear();
                    mskCPF.Text = "";
                    codLoc = 0;
                    limpar.limparDGV(dgvItensAlugados);
                }
            }
        }
    }
}
