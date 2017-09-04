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
using Microsoft.Office.Interop.Excel;

namespace BiblioTechnology.View
{
    // exportar para excel os livros em atraso
    public partial class frmHome : Form
    {
        frmPrincipal principal = new frmPrincipal();
        Locacao locacao = new Locacao();
        frmDevolucao devolucao = new frmDevolucao();
        OperacoesForm ofrm = new OperacoesForm();
        ConverterData conData = new ConverterData();
        public frmHome(frmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            dgvDevolucoesPendentes.DataSource = locacao.consDevolucoesDia(conData.converterData(dtpData.Value)).Tables[0];
            dgvDevolucoesAtraso.DataSource = locacao.consDevolucoesAtraso(conData.converterData(dtpDataPendentes.Value)).Tables[0];
            dgvDevolucoesAtraso.Columns[0].Visible = false;
            dgvDevolucoesAtraso.Columns[1].Visible = false;
            dgvDevolucoesPendentes.Columns[0].Visible = false;
            dgvDevolucoesPendentes.Columns[1].Visible = false;
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            try {

                this.UseWaitCursor = true;
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
                WorkSheet.Cells[1, 3] = "Nome";
                WorkSheet.Cells[1, 4] = "Turma";
                WorkSheet.Cells[1, 5] = "Tel";
                WorkSheet.Cells[1, 6] = "Data de devolução";

                int l = 2;
                for (i = 0; i <= dgvDevolucoesAtraso.Rows.Count - 1; i++)
                {
                    for (j = 2; j <= dgvDevolucoesAtraso.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvDevolucoesAtraso[j, i];
                        WorkSheet.Cells[l, j - 1] = cell.Value;

                    }
                    l += 1;
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
                MessageBox.Show("Ocorreu um erro: "+ ex.Message);
            }

            }
        

        private void dgvDevolucoesAtraso_DoubleClick(object sender, EventArgs e)
        {
            
            ofrm.chamarFrm(principal, devolucao);
            devolucao.buscaLocCod(Convert.ToInt32( dgvDevolucoesAtraso.CurrentRow.Cells[0].Value.ToString()),Convert.ToInt16(dgvDevolucoesAtraso.CurrentRow.Cells[1].Value.ToString()));
            
        }

        private void dgvDevolucoesPendentes_DoubleClick(object sender, EventArgs e)
        {
            ofrm.chamarFrm(principal, devolucao);
            devolucao.buscaLocCod(Convert.ToInt32(dgvDevolucoesPendentes.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt16(dgvDevolucoesPendentes.CurrentRow.Cells[1].Value.ToString()));

        }
    }
    }

