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
    public partial class frmLivros : Form
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm ofrm = new OperacoesForm();
        Editora editora = new Editora();
        Genero genero = new Genero();
        Livro livro = new Livro();
        TipoMaterial tipoMaterial = new TipoMaterial();
        Limpar limpar = new Limpar();
        public bool consulta = false;
        public frmLivros(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }
        public frmLivros()
        {
            InitializeComponent(); 
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            carregaCBOs();
        }
        private void carregaCBOs()
        {
            cboEditora.DataSource = editora.consEditoraNome("").Tables[0];
            cboEditora.DisplayMember = "Nome";
            cboEditora.ValueMember = "Código";
            cboEditora.SelectedIndex = -1;

            cboGenero.DataSource = genero.consGenero("").Tables[0];
            cboGenero.DisplayMember = "Gênero";
            cboGenero.SelectedIndex = -1;

            cboAutor.DataSource = livro.consLivrosAutor().Tables[0];
            cboAutor.DisplayMember = "AUTOR_LIVRO";
            cboAutor.SelectedIndex = -1;

            cboTipo.DataSource = tipoMaterial.consTipoMaterial("").Tables[0];
            cboTipo.DisplayMember = "Tipo Material";
            cboTipo.SelectedIndex = -1;
        }
        public void recarregaCBOGenero()
        {
            cboGenero.DataSource = genero.consGenero("").Tables[0];
            cboGenero.DisplayMember = "Gênero";
        }
        public void recarregaCBOEditora()
        {
            cboEditora.DataSource = editora.consEditoraNome("").Tables[0];
            cboEditora.DisplayMember = "Nome";
            cboEditora.ValueMember = "Código";
        }
        public void recarregaCBOMaterial()
        {
            cboTipo.DataSource = tipoMaterial.consTipoMaterial("").Tables[0];
            cboTipo.DisplayMember = "Tipo Material";
        }

        private void btnAddEditora_Click(object sender, EventArgs e)
        {
            frmEditora editora = new frmEditora(this);
            ofrm.chamarFrm(contexto, editora);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsuLivro consuLivro = new frmConsuLivro(this);
            ofrm.chamarFrm(contexto, consuLivro);
        }

        private void btnAddGenero_Click(object sender, EventArgs e)
        {
            frmGenero genero = new frmGenero(this);
            genero.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            string editora;
            if (cboEditora.SelectedValue == null)
            {
                editora = "";
            }
            else
            {
                editora = cboEditora.SelectedValue.ToString();
            }
            if (cboTipo.SelectedIndex != -1)
            {
                if (txtTitulo.Text != "")
                {
                    if (consulta)
                    {
                        livro.atuaLivro(Convert.ToInt32(txtCod.Text), txtTitulo.Text, cboAutor.Text, txtEdicao.Text, txtAno.Text, cboGenero.Text, editora, txtLugar.Text, chekAtivo.Checked, chekAluga.Checked, cboTipo.Text, rtxtOBS.Text);
                        btnNovo_Click(sender, e);
                    }
                    else
                    {
                        livro.cadLivro(txtTitulo.Text, cboAutor.Text, txtEdicao.Text, txtAno.Text, cboGenero.Text, editora, txtLugar.Text, chekAtivo.Checked, chekAluga.Checked, cboTipo.Text, rtxtOBS.Text);
                        btnNovo_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Digite o título.");
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo do material.");
            }  
        }

        public void btnNovo_Click(object sender, EventArgs e)
        {
             
            limpar.limpar(panel1);
            chekAtivo.Checked = true;
            chekAluga.Checked = true;
            consulta = false;
            btnSalvar.Text = "Cadastrar";
        }

        private void btnAddTipo_Click(object sender, EventArgs e)
        {
            frmTipoMaterial tipoMaterial = new frmTipoMaterial(this);
            tipoMaterial.ShowDialog();
        }

        private void cboGenero_Validated(object sender, EventArgs e)
        {
            if (cboGenero.SelectedIndex == -1)
            {
                cboGenero.Text = "";
            }
        }

        private void cboTipo_Validated(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == -1)
            {
                cboTipo.Text = "";
            }
        }

        private void cboEditora_Validated(object sender, EventArgs e)
        {
            if (cboEditora.SelectedIndex == -1)
            {
                cboEditora.Text = "";
            }
        }
    }
}
