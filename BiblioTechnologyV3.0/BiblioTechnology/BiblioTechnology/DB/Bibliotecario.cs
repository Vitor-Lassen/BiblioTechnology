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
    class Bibliotecario
    {
        Conexao con = new Conexao();
        public void cadBibliotecario(string usuario, string senha, string nome, string email, bool sexo, bool ativo)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_BIBLIOTECARIO values (@usuario,@senha,@nome,@email,@sexo,@ativo)", con.conectarBD());
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@ativo", SqlDbType.VarChar).Value = ativo;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
           MessageBox.Show( "Bibliotecário cadastrado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
        public void atuaBibliotecario(string usuario, string senha, string nome, string email, bool sexo, bool ativo)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_BIBLIOTECARIO SET SENHA_BLI = @senha,NOME_BLI = @nome,EMAIL_BLI = @email,SEXO_BLI = @sexo,ATIVO_BLI = @ativo WHERE USUARIO_BLI = @usuario ", con.conectarBD());
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@ativo", SqlDbType.VarChar).Value = ativo;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MessageBox.Show("Bibliotecário atualizado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public DataSet consBibliotecarioUsuario(string usuario)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT USUARIO_BLI AS 'Usuário', NOME_BLI AS 'Nome', EMAIL_BLI AS 'E-mail' FROM TB_BIBLIOTECARIO WHERE USUARIO_BLI LIKE '%"+ usuario +"%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consBibliotecarioNome(string nome)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT USUARIO_BLI AS 'Usuário', NOME_BLI AS 'Nome', EMAIL_BLI AS 'E-mail' FROM TB_BIBLIOTECARIO WHERE NOME_BLI LIKE '%" + nome + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consBibliotecarioDetalhes (string usuario)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_BIBLIOTECARIO WHERE USUARIO_BLI='" + usuario + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public string Login(string usuario, string senha)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NOME_BLI FROM TB_BIBLIOTECARIO WHERE USUARIO_BLI='" + usuario + "' and SENHA_BLI = '" + senha + "'and ATIVO_BLI = 1", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                return "";
            }
        }
        public bool consBibliotecariosAtivos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_BIBLIOTECARIO WHERE ATIVO_BLI='TRUE'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            if (Convert.ToInt16(ds.Tables[0].Rows.Count.ToString()) > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
