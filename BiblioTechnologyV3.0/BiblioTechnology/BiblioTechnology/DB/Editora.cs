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
    class Editora
    {

        Conexao con = new Conexao();
        public void cadEditora(string nome, string tel, string email, string site, string end, string numero, string complemento, string bairro, string cidade, string cep)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_EDITORA VALUES (@nome,@tel,@email,@site,@end,@numero,@complemento,@bairro,@cidade,@cep)", con.conectarBD());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@site", SqlDbType.VarChar).Value = site;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MessageBox.Show("Editora cadastrada com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public void atuaEditora(int cod, string nome, string tel, string email, string site, string end, string numero, string complemento, string bairro, string cidade, string cep)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_EDITORA SET NOME_EDIT = @nome,TEL_EDIT = @tel, EMAIL_EDIT = @email,SITE_EDIT = @site,END_EDIT = @end,NUMERO_EDIT = @numero,COMPLEMENTO_EDIT = @complemento,BAIRRO_EDIT = @bairro,CIDADE_EDIT = @cidade,CEP_EDIT = @cep WHERE COD_EDIT = @cod", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@site", SqlDbType.VarChar).Value = site;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MessageBox.Show("Locatário atualizado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public DataSet consEditoraNome(string nome)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_EDIT AS 'Código', NOME_EDIT AS 'Nome', SITE_EDIT AS 'Site'  FROM TB_EDITORA WHERE NOME_EDIT LIKE '%" + nome + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consEditoraDetalhes(int cod)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM TB_EDITORA WHERE COD_EDIT='" + cod + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consEditoracboBairro()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT BAIRRO_EDIT FROM TB_EDITORA", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consEditoracboCidade()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT CIDADE_EDIT FROM TB_EDITORA", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }

    }
}
