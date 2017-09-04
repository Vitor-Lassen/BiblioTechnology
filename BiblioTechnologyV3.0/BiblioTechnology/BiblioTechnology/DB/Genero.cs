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
    class Genero
    {

        Conexao con = new Conexao();
        public void cadGenero(string genero)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_GENERO VALUES (@genero)", con.conectarBD());
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
           
            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public DataSet consGenero(string genero)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT GENERO AS 'Gênero'  FROM TB_GENERO WHERE GENERO LIKE '%" + genero + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consGeneroNome(string genero)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT GENERO AS 'Gênero'  FROM TB_GENERO WHERE GENERO ='" + genero + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }

    }
}
