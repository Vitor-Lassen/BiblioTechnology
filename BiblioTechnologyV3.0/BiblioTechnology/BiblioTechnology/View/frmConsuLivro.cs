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
using Microsoft.Office.Interop.Excel;

namespace BiblioTechnology.View
{
    public partial class frmConsuLivro : Form
    {
        Livro livro = new Livro();
        DataSet dsLivros = new DataSet();
        frmLivros contextoLivros = new frmLivros();
        public frmConsuLivro(frmLivros contexto)
        {
            InitializeComponent();
            contextoLivros = contexto;
        }
        private void enterLimpar(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtAutor.Clear();
            txtNome.Clear();
            cboGenero.SelectedIndex = -1;
            cboGenero.Text = "";
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

            dsLivros = livro.consLivroNome(txtNome.Text);
            formataGrid(sender, e);
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            dsLivros = livro.consLivroAutor(txtAutor.Text);
            formataGrid(sender, e);
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            chekAlugados.Checked = true;
            chekInativos.Checked = true;
            chekNaoAluga.Checked = true;
            try
            {
                dsLivros = livro.consLivroCodigo(Convert.ToInt32(txtCod.Text));
                formataGrid(sender, e);
            }
            catch { }
        }

        private void cboGenero_TextChanged(object sender, EventArgs e)
        {
            dsLivros = livro.consLivroGenero(cboGenero.Text);
            formataGrid(sender, e);
        }

        private void formataGrid(object sender, EventArgs e)
        {
            for (int i = 0; i < dsLivros.Tables[0].Rows.Count; i++)
            {
                bool del = false;
                if (chekInativos.Checked == false)
                {
                    if (Convert.ToBoolean(dsLivros.Tables[0].Rows[i].ItemArray[7].ToString()) == false)
                    {
                        del = true;
                    }
                }
                if (chekNaoAluga.Checked == false)
                {
                    if (Convert.ToBoolean(dsLivros.Tables[0].Rows[i].ItemArray[6].ToString()) == false)
                    {
                        del = true;
                    }
                }
                if (chekAlugados.Checked == false)
                {
                    if (Convert.ToBoolean(dsLivros.Tables[0].Rows[i].ItemArray[5].ToString()) == true)
                    {
                        del = true;
                    }
                }
                if (del)
                {
                    dsLivros.Tables[0].Rows.RemoveAt(i);
                    i -= 1;
                }
            }
            dgvLivros.DataSource = dsLivros.Tables[0];
        }
        private void verificaBusca(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                txtCod_TextChanged(sender, e);
            }
            else if (txtNome.Text != "")
            {
                txtNome_TextChanged(sender, e);
            }
            else if (txtAutor.Text != "")
            {
                txtAutor_TextChanged(sender, e);
            }
            else if (cboGenero.Text != "")
            {
                cboGenero_TextChanged(sender, e);
            }
            else
            {
                dsLivros = livro.consLivroNome("");
                formataGrid(sender, e);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            contextoLivros.btnNovo_Click(sender, e);
            contextoLivros.consulta = true;
            int cod = Convert.ToInt32(dgvLivros.CurrentRow.Cells[0].Value.ToString());
            DataSet ds = new DataSet();
            ds = livro.consLivroDetalhes(cod);
            contextoLivros.txtCod.Text = cod.ToString();
            contextoLivros.txtTitulo.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            if (ds.Tables[0].Rows[0].ItemArray[2].ToString() != "")
            {
                contextoLivros.cboAutor.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            contextoLivros.txtEdicao.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            contextoLivros.txtAno.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            if (ds.Tables[0].Rows[0].ItemArray[5].ToString() != "")
            {
                contextoLivros.cboGenero.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            }
            if (ds.Tables[0].Rows[0].ItemArray[6].ToString() != "")
            {
                contextoLivros.cboEditora.SelectedValue = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            contextoLivros.txtLugar.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            contextoLivros.chekAtivo.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[8].ToString());
            contextoLivros.chekAluga.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[9].ToString());
            contextoLivros.cboTipo.Text = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            contextoLivros.rtxtOBS.Text = ds.Tables[0].Rows[0].ItemArray[12].ToString();
            contextoLivros.btnSalvar.Text = "Salvar";
            Close();

        }

        private void frmConsuLivro_Load(object sender, EventArgs e)
        {
            Genero genero = new Genero();

            cboGenero.DataSource = genero.consGenero("").Tables[0];
            cboGenero.DisplayMember = "Gênero";
            cboGenero.SelectedIndex = -1;
            verificaBusca(sender, e);


        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            try
            {
                UseWaitCursor = true;
                SaveFileDialog salvar = new SaveFileDialog();
                Microsoft.Office.Interop.Excel.Application App;
                Workbook WorkBook;
                Worksheet WorkSheet;
                object misValue = System.Reflection.Missing.Value;

                App = new Microsoft.Office.Interop.Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                // passa as celulas do DataGridView para a Pasta do Excel
                WorkSheet.Cells[1, 1] = "Código";
                WorkSheet.Cells[1, 2] = "Título";
                WorkSheet.Cells[1, 3] = "Autor";
                WorkSheet.Cells[1, 4] = "Gênero";
                WorkSheet.Cells[1, 5] = "Lugar";
                WorkSheet.Cells[1, 6] = "Alugado?";
                WorkSheet.Cells[1, 7] = "Aluga?";
                WorkSheet.Cells[1, 8] = "Ativo?";
                int l = 2, c = 1;
                for (i = 0; i <= dgvLivros.Rows.Count - 1; i++)
                {
                    for (j = 0; j <= 4; j++)
                    {
                        DataGridViewCell cell = dgvLivros[j, i];
                        WorkSheet.Cells[l, c] = cell.Value;
                        c += 1;
                    }
                    l += 1;
                    c = 1;
                }
                l = 2;
                c = 6;
                for (i = 0; i <= dgvLivros.Rows.Count - 1; i++)
                {
                    for (j = 5; j <= 7; j++)
                    {

                        bool cell = Convert.ToBoolean(dgvLivros.Rows[i].Cells[j].Value.ToString());
                        string valor;
                        if (cell)
                        {
                            valor = "Sim";
                        }
                        else
                        {
                            valor = "Não";
                        }
                        WorkSheet.Cells[l, c] = valor;
                        c += 1;
                    }
                    l += 1;
                    c = 6;
                }

                // define algumas propriedades da caixa salvar
                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                salvar.ShowDialog(); // mostra

                // salva o arquivo
                WorkBook.SaveAs(salvar.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit(); // encerra o excel

                MessageBox.Show("Exportado com sucesso!");
                UseWaitCursor = false;
            }
            catch (Exception ex)
            {
                UseWaitCursor = false;
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
               
            }
        }
    }
    }

