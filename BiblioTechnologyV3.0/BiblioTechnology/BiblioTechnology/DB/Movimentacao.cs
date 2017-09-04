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
    class Movimentacao
    {
        Conexao con = new Conexao();
        public DataSet gerarRelatorioMovimentacao(string dataInicio, string dataFim)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(" SELECT MOVIMENTACAO AS 'Movimentação' , TIPO_MATERIAL AS 'Material' , COUNT(MOVIMENTACAO) AS 'Quantidade' FROM TB_MOVIMENTACAO WHERE DATA_MOVIMENTACAO > '"+dataInicio+"' AND DATA_MOVIMENTACAO <  '"+dataFim+"'  GROUP BY MOVIMENTACAO ,TIPO_MATERIAL  ", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public void cadMovimentacao(string tipo,string movimentacao, DateTime datamovimentacao)
        {
            BiblioTechnology.Utilities.ConverterData conData = new Utilities.ConverterData();
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_MOVIMENTACAO VALUES (@tipo,@movimentacao , @data)", con.conectarBD());
            cmd.Parameters.Add("@movimentacao", SqlDbType.VarChar).Value = movimentacao;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = conData.converterData(DateTime.Now);

            cmd.ExecuteNonQuery();

            con.desconectarBD();

           
        }
    }
}
