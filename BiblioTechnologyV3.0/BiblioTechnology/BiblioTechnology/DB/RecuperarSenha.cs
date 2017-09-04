using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BiblioTechnology.Utilities;


namespace  BiblioTechnology.DB
{
    class RecuperarSenha
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public bool recuperarSenha1(string email, string cod)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_BIBLIOTECARIO where EMAIL_BLI = '" + email + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            if (ds.Tables[0].Rows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand("update TB_BIBLIOTECARIO set SENHA_BLI=@cod where EMAIL_BLI=@email ", con.conectarBD());
                cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.ExecuteNonQuery();
                return true;
            }
            con.desconectarBD();
            return false;

        }
        public bool recuperarSenha2(string cod)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_BIBLIOTECARIO where SENHA_BLI = '" + cod + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void recuperarSenha3(string senha, string cod)
        {
            SqlCommand cmd = new SqlCommand("update TB_BIBLIOTECARIO set SENHA_BLI=@senha where SENHA_BLI=@cod ", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cmd.ExecuteNonQuery();
        }
    }
}
