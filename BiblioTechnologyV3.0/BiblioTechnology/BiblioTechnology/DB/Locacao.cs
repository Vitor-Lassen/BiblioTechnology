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
    class Locacao
    {
        Conexao con = new Conexao();
        Movimentacao movimentacao = new Movimentacao();
        public void cadLocacao( int codLoc, int codLivro, DateTime dataLoc, DateTime dataDevo)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_LOCACAO (COD_LOC,COD_LIVRO,DATA_LOCACAO,DATA_DEVOLUCAO) values (@codLoc,@codLivro,@dataLoc,@dataDevo)", con.conectarBD());
            cmd.Parameters.Add("@codLoc", SqlDbType.VarChar).Value = codLoc;
            cmd.Parameters.Add("@codLivro", SqlDbType.VarChar).Value = codLivro;
            cmd.Parameters.Add("@dataLoc", SqlDbType.Date).Value = dataLoc;
            cmd.Parameters.Add("@dataDevo", SqlDbType.Date).Value = dataDevo;
            cmd.ExecuteNonQuery();

            con.desconectarBD();

            SqlCommand cmd2 = new SqlCommand("UPDATE TB_LIVRO SET ALUGADO_LIVRO = 'TRUE' WHERE COD_LIVRO = @codLivro", con.conectarBD());
            cmd2.Parameters.Add("@codLivro", SqlDbType.VarChar).Value = codLivro;
            cmd2.ExecuteNonQuery();

            con.desconectarBD();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LIVRO WHERE COD_LIVRO =" + codLivro, con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            string tipo =  ds.Tables[0].Rows[0].ItemArray[11].ToString();

            movimentacao.cadMovimentacao(tipo, "Locação", DateTime.Now);

            MessageBox.Show("Locação realizada com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public void renovacao(int cod, DateTime dataDevolucao, int codLivro)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_LOCACAO SET DATA_DEVOLUCAO = @devolucao WHERE COD_LOCACAO= @cod ", con.conectarBD());
            cmd.Parameters.Add("@devolucao", SqlDbType.Date).Value = dataDevolucao;
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;

            cmd.ExecuteNonQuery();

            con.desconectarBD();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LIVRO WHERE COD_LIVRO =" + codLivro, con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            string tipo = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            movimentacao.cadMovimentacao(tipo, "Renovação", DateTime.Now);
          
        }
        public void devolucao(int cod, DateTime data, int codLivro)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_LOCACAO SET DEVOLUCAO = @data WHERE COD_LOCACAO = @cod", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@data", SqlDbType.Date).Value = data;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("UPDATE TB_LIVRO SET ALUGADO_LIVRO = 'FALSE' WHERE COD_LIVRO = @codLivro", con.conectarBD());
            cmd2.Parameters.Add("@codLivro", SqlDbType.VarChar).Value = codLivro;
            cmd2.ExecuteNonQuery();

            con.desconectarBD();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LIVRO WHERE COD_LIVRO =" + codLivro, con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            string tipo = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            movimentacao.cadMovimentacao(tipo, "Devolução", DateTime.Now);
            
        }

        public int consQTDLivrosAlugadosLoc(int codLoc)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCACAO WHERE COD_LOC =" + codLoc + " AND DEVOLUCAO IS NULL", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            return Convert.ToInt32(ds.Tables[0].Rows.Count);
        }
        public DataSet consLivrosAlugadosLoc(int codLoc)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LOCACAO WHERE COD_LOC =" + codLoc + " AND DEVOLUCAO IS NULL", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            return ds;
        }
        public DataSet consDevolucoesDia(string data)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT LOC.COD_LOC, LOC.TIPO_LOC, LI.COD_LIVRO AS 'Código',LI.TITULO_LIVRO AS 'Título', LOC.NOME_LOC AS 'Nome',LOC.TURMA_LOC As 'Turma',LOC.TEL_LOC AS 'Tel', LOCACAO.DATA_DEVOLUCAO AS 'Data de devolução' FROM TB_LIVRO AS LI INNER JOIN TB_LOCACAO AS LOCACAO ON LI.COD_LIVRO = LOCACAO.COD_LIVRO INNER JOIN TB_LOCATARIO AS LOC ON LOCACAO.COD_LOC = LOC.COD_LOC WHERE  LOCACAO.DEVOLUCAO IS NULL AND LOCACAO.DATA_DEVOLUCAO = '"+data+"'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            return ds;
        }
        public DataSet consDevolucoesAtraso(string data)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT LOC.COD_LOC, LOC.TIPO_LOC, LI.COD_LIVRO AS 'Código',LI.TITULO_LIVRO AS 'Título', LOC.NOME_LOC AS 'Nome',LOC.TURMA_LOC As 'Turma',LOC.TEL_LOC AS 'Tel', LOCACAO.DATA_DEVOLUCAO AS 'Data de devolução' FROM TB_LIVRO AS LI INNER JOIN TB_LOCACAO AS LOCACAO ON LI.COD_LIVRO = LOCACAO.COD_LIVRO INNER JOIN TB_LOCATARIO AS LOC ON LOCACAO.COD_LOC = LOC.COD_LOC WHERE  LOCACAO.DEVOLUCAO IS NULL AND LOCACAO.DATA_DEVOLUCAO <'" + data + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();

            return ds;
        }
    }
}

