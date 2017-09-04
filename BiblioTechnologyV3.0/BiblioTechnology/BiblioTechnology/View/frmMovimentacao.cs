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
    public partial class frmMovimentacao : Form
    {
        // relatorio de renovação, locação
        Movimentacao movimentacao = new Movimentacao();
        ConverterData condata = new ConverterData();
        public frmMovimentacao()
        {
            InitializeComponent();
        }
        public void gerarRelatorio(object sender, EventArgs e)
        {
             dgvRelatorio.DataSource= movimentacao.gerarRelatorioMovimentacao(condata.converterData(dtpInicio.Value), condata.converterData(dtpFim.Value)).Tables[0];
            //dgvRelatorio.DataSource = movimentacao.gerarRelatorioMovimentacao(dtpInicio.ToString(), dtpFim.ToString()).Tables[0];

        }
    }
}
