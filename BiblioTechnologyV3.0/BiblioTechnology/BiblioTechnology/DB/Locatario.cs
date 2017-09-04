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
    class Locatario
    {
        Conexao con = new Conexao();
        public void cadLocatario(int tipo, string rm, string cpf, string nome, bool sexo, string turma, string tel, string cel, string end, string numero, string complemento, string bairro, string cidade, string cep, string obs, bool ativo)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_LOCATARIO values (@tipo,@rm,@cpf,@nome,@sexo,@turma,@tel,@cel,@end,@numero,@complemento,@bairro,@cidade,@cep,@obs,@ativo)", con.conectarBD());
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("@rm", SqlDbType.VarChar).Value = rm;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            cmd.Parameters.Add("@turma", SqlDbType.VarChar).Value = turma;
            cmd.Parameters.Add("@tel ", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = cel;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            cmd.Parameters.Add("@ativo", SqlDbType.VarChar).Value = ativo;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MessageBox.Show("Locatário cadastrado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public void atuaLocatario(int cod,int tipo, string rm, string cpf, string nome, bool sexo, string turma, string tel, string cel, string end, string numero, string complemento, string bairro, string cidade, string cep, string obs, bool ativo)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_LOCATARIO SET TIPO_LOC = @tipo,RM_LOC = @rm, CPF_LOC = @cpf,NOME_LOC = @nome,SEXO_LOC = @sexo,TURMA_LOC = @turma,TEL_LOC = @tel,CEL_LOC = @cel,END_LOC = @end,NUMERO_LOC = @numero,COMPLEMENTO_LOC = @complemento,BAIRRO_LOC = @bairro,CIDADE_LOC = @cidade,CEP_LOC = @cep,OBS_LOC = @obs,ATIVO_LOC = @ativo WHERE COD_LOC = @cod", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("@rm", SqlDbType.VarChar).Value = rm;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            cmd.Parameters.Add("@turma", SqlDbType.VarChar).Value = turma;
            cmd.Parameters.Add("@tel ", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = cel;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            cmd.Parameters.Add("@ativo", SqlDbType.VarChar).Value = ativo;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MessageBox.Show("Locatário atualizado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
       
        public DataSet consLocatarioNome(string nome, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LOC AS 'Código', RM_LOC AS 'RM', CPF_LOC AS 'CPF', NOME_LOC AS 'Nome', TURMA_LOC AS 'Turma'  FROM TB_LOCATARIO WHERE NOME_LOC LIKE '%" + nome + "%' AND TIPO_LOC='"+tipo+"'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocacaoCod(int cod)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCATARIO WHERE COD_LOC='" + cod + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocacaoNome(string nome, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCATARIO WHERE NOME_LOC='" + nome + "' AND TIPO_LOC='" + tipo + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocatarioRM(string rm, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LOC AS 'Código', RM_LOC AS 'RM', CPF_LOC AS 'CPF', NOME_LOC AS 'Nome', TURMA_LOC AS 'Turma' FROM TB_LOCATARIO WHERE RM_LOC LIKE '%" + rm + "%' AND TIPO_LOC='" + tipo + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocacaoRM(string rm, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCATARIO WHERE RM_LOC ='" + rm + "' AND TIPO_LOC='" + tipo + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocatarioCPF(string CPF, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LOC AS 'Código', RM_LOC AS 'RM', CPF_LOC AS 'CPF', NOME_LOC AS 'Nome', TURMA_LOC AS 'Turma' FROM TB_LOCATARIO WHERE CPF_LOC LIKE '%" + CPF + "%' AND TIPO_LOC='" + tipo + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocacaoCPF(string CPF, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCATARIO WHERE CPF_LOC = '" + CPF + "' AND TIPO_LOC='" + tipo + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocatarioTurma(string turma, int tipo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LOC AS 'Código', RM_LOC AS 'RM', CPF_LOC AS 'CPF', NOME_LOC AS 'Nome', TURMA_LOC AS 'Turma' FROM TB_LOCATARIO WHERE TURMA_LOC LIKE '%" + turma + "%' AND TIPO_LOC='" + tipo + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocatarioDetalhes(int cod)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCATARIO WHERE COD_LOC='" + cod + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }

        public bool consLocatarioAtivo(int cod)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ATIVO_LOC FROM TB_LOCATARIO WHERE COD_LOC='" + cod + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            
            return Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[0].ToString());
        }

        public DataSet consLocatariocboBairro()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT BAIRRO_LOC FROM TB_LOCATARIO", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocatariocboCidade()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT CIDADE_LOC FROM TB_LOCATARIO", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLocatariocboTurma()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT TURMA_LOC FROM TB_LOCATARIO", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
    }
}
