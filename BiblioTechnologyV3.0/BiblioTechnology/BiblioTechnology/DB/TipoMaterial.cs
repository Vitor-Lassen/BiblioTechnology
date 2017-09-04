using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BiblioTechnology.DB
{
    class TipoMaterial
    {

        Conexao con = new Conexao();
        public void cadTipoMaterial(string tipoMaterial)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_TIPO_MATERIAL VALUES (@tipoMaterial)", con.conectarBD());
            cmd.Parameters.Add("@tipoMaterial", SqlDbType.VarChar).Value = tipoMaterial;

            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public DataSet consTipoMaterial(string tipoMaterial)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TIPO_MATERIAL AS 'Tipo Material'  FROM TB_TIPO_MATERIAL WHERE TIPO_MATERIAL LIKE '%" + tipoMaterial + "%'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consTipoMaterialNome(string tipoMaterial)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TIPO_MATERIAL AS 'Tipo Material'  FROM TB_TIPO_MATERIAL WHERE TIPO_MATERIAL ='" + tipoMaterial + "'", con.conectarBD());
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }

    }
}

