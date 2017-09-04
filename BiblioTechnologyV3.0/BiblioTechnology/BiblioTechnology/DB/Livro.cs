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
    class Livro
    {
        Conexao con = new Conexao();
        public void cadLivro(string titulo, string autor, string edicao, string ano_lancamento, string genero, string codEditora, string lugar, bool ativo, bool aluga, string tipo, string obs)
        {
           
           
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_LIVRO VALUES (@titulo,@autor,@edicao,@ano_lancamento,@genero,@codEditora,@lugar,@ativo,@aluga,0,@tipo_material,@obs)", con.conectarBD());
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = autor;
            cmd.Parameters.Add("@edicao", SqlDbType.VarChar).Value = edicao;
            cmd.Parameters.Add("@ano_lancamento", SqlDbType.VarChar).Value = ano_lancamento;
            if (genero == "")
            {
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
            }
            if (codEditora == "")
            {
                cmd.Parameters.Add("@codEditora", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@codEditora", SqlDbType.VarChar).Value = codEditora;
            }
            cmd.Parameters.Add("@lugar", SqlDbType.VarChar).Value = lugar;
            cmd.Parameters.Add("@ativo", SqlDbType.VarChar).Value = ativo;
            cmd.Parameters.Add("@aluga", SqlDbType.VarChar).Value = aluga;
            cmd.Parameters.Add("@tipo_material", SqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;

            cmd.ExecuteNonQuery();

            con.desconectarBD();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(COD_LIVRO) FROM TB_LIVRO", con.conectarBD());
            da.Fill(ds);

            con.desconectarBD();
            int codLivro = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            MessageBox.Show("Livro cadastrado com sucesso! \nCódigo do Livro : "+ codLivro.ToString(), "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public void atuaLivro(int cod,string titulo, string autor, string edicao, string ano_lancamento, string genero, string codEditora, string lugar, bool ativo,bool aluga, string tipo, string obs)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TB_LIVRO SET  TITULO_LIVRO = @titulo, AUTOR_LIVRO = @autor, EDICAO_LIVRO = @edicao,ANO_LANCAMENTO = @ano_lancamento,GENERO = @genero,COD_EDIT = @codEditora,LUGAR_LIVRO = @lugar,ATIVO_LIVRO = @ativo,ALUGA_LIVRO = @aluga,TIPO_MATERIAL = @tipo_material,OBS_LIVRO = @obs WHERE COD_LIVRO = @cod", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = autor;
            cmd.Parameters.Add("@edicao", SqlDbType.VarChar).Value = edicao;
            cmd.Parameters.Add("@ano_lancamento", SqlDbType.VarChar).Value = ano_lancamento;
            if (genero == "")
            {
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
            }
            if (codEditora == "")
            {
                cmd.Parameters.Add("@codEditora", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@codEditora", SqlDbType.VarChar).Value = codEditora;
            }
            cmd.Parameters.Add("@lugar", SqlDbType.VarChar).Value = lugar;
            cmd.Parameters.Add("@ativo", SqlDbType.VarChar).Value = ativo;
            cmd.Parameters.Add("@aluga", SqlDbType.VarChar).Value = aluga;
            cmd.Parameters.Add("@tipo_material", SqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MessageBox.Show("Livro atualizado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public DataSet consLivroNome(string titulo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LIVRO AS 'Código', TITULO_LIVRO AS 'Título', AUTOR_LIVRO AS 'Autor', GENERO AS 'Gênero', LUGAR_LIVRO AS 'Lugar', ALUGADO_LIVRO AS 'Alugado?', ALUGA_LIVRO AS 'Aluga?', ATIVO_LIVRO AS 'Ativo?'  FROM TB_LIVRO WHERE TITULO_LIVRO LIKE '%" + titulo + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLivroCodigo(int cod)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LIVRO AS 'Código', TITULO_LIVRO AS 'Título', AUTOR_LIVRO AS 'Autor', GENERO AS 'Gênero', LUGAR_LIVRO AS 'Lugar', ALUGADO_LIVRO AS 'Alugado?', ALUGA_LIVRO AS 'Aluga?', ATIVO_LIVRO AS 'Ativo?'  FROM TB_LIVRO WHERE COD_LIVRO='" + cod + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLivroAutor(string autor)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LIVRO AS 'Código', TITULO_LIVRO AS 'Título', AUTOR_LIVRO AS 'Autor', GENERO AS 'Gênero', LUGAR_LIVRO AS 'Lugar', ALUGADO_LIVRO AS 'Alugado?', ALUGA_LIVRO AS 'Aluga?', ATIVO_LIVRO AS 'Ativo?'  FROM TB_LIVRO WHERE AUTOR_LIVRO LIKE '%" + autor + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLivroGenero(string genero)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COD_LIVRO AS 'Código', TITULO_LIVRO AS 'Título', AUTOR_LIVRO AS 'Autor', GENERO AS 'Gênero', LUGAR_LIVRO AS 'Lugar', ALUGADO_LIVRO AS 'Alugado?', ALUGA_LIVRO AS 'Aluga?', ATIVO_LIVRO AS 'Ativo?'  FROM TB_LIVRO WHERE GENERO LIKE '%" + genero + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLivroDetalhes(int cod)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_LIVRO WHERE COD_LIVRO='" + cod + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consLivrosAutor()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT AUTOR_LIVRO FROM TB_LIVRO", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
    }
}
