using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BiblioTechnology.DB
{
    class Config
    {
        Conexao con = new Conexao();

        public void atuaConfig(string locacaoAluno, string locacaoFuncionario, string locacaoServidor, string locacaoPublico, string materialAluno, string materialFuncionario, string materialServidor, string materialPublico)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_CONFIGURACAO SET TEMPO_LOCACAO_ALUNO = @LocacaoAluno,TEMPO_LOCACAO_FUNCIONARIO= @LocacaoFuncionario,TEMPO_LOCACAO_SERVIDOR = @LocacaoServidor,TEMPO_LOCACAO_PUBLICO = @LocacaoPublico,QUANTIDADE_LIVROS_ALUNO = @MaterialAluno, QUANTIDADE_LIVROS_FUNCIONARIO = @MaterialFuncionario,QUANTIDADE_LIVROS_SERVIDOR = @MaterialServidor,QUANTIDADE_LIVROS_PUBLICO = @MaterialPublico WHERE COD_CONFIG = 1 ", con.conectarBD());
            cmd.Parameters.Add("@LocacaoAluno", SqlDbType.VarChar).Value = locacaoAluno;
            cmd.Parameters.Add("@LocacaoFuncionario", SqlDbType.VarChar).Value = locacaoFuncionario;
            cmd.Parameters.Add("@LocacaoServidor", SqlDbType.VarChar).Value = locacaoServidor;
            cmd.Parameters.Add("@LocacaoPublico", SqlDbType.VarChar).Value = locacaoPublico;
            cmd.Parameters.Add("@MaterialAluno", SqlDbType.VarChar).Value = materialAluno;
            cmd.Parameters.Add("@MaterialFuncionario", SqlDbType.VarChar).Value = materialFuncionario;
            cmd.Parameters.Add("@MaterialServidor", SqlDbType.VarChar).Value = materialServidor;
            cmd.Parameters.Add("@MaterialPublico", SqlDbType.VarChar).Value = materialPublico;
            cmd.ExecuteNonQuery();
            
            con.desconectarBD();
            MessageBox.Show("Configurações atualizado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public DataSet consConfig()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_CONFIGURACAO WHERE COD_CONFIG = 1", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
    }
}
