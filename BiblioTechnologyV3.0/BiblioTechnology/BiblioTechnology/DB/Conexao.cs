using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTechnology
{
    class Conexao
    {
       //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\DB\DB_BIBLIOTECHNOLOGY.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Password=1234567;Persist Security Info=True;User ID=cliente;Initial Catalog=DB_BIBLIOTECHNOLOGY;Data Source=192.168.25.16");

        public SqlConnection conectarBD()
        {
            try
            {
                con.Open();                
            }
            catch
            {
            }
            return con;
        }
        public SqlConnection desconectarBD()
        {
            con.Close();
            return con;
       }
        public SqlConnection desconectarBD_Backup()
        {
            con.Close();
            SqlConnection.ClearAllPools();
            var process = System.Diagnostics.Process.GetProcessesByName("sqlservr");
            foreach (var p in process)
            {
                p.Kill();
            }
            return con;
        }
    }
}
 