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
    public partial class frmConfig : Form
    {
        Config config = new Config();
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            carregaConfig();
        }
        private void carregaConfig()
        {
            DataSet ds = new DataSet();
            ds = config.consConfig();
            txtLocacaoAluno.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            txtLocacaoFuncionario.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            txtLocacaoServidores.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            txtLocacaoPublico.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            txtMaterialAluno.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            txtMaterialFuncionario.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            txtMaterialServidores.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            txtMaterialPublico.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            config.atuaConfig(txtLocacaoAluno.Text, txtLocacaoFuncionario.Text, txtLocacaoServidores.Text, txtLocacaoPublico.Text, txtMaterialAluno.Text, txtMaterialFuncionario.Text, txtMaterialServidores.Text, txtMaterialPublico.Text);
        }
    }
}
