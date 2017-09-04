using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;


namespace BiblioTechnology.Utilities
{
    class Backup
    {
        Conexao con = new Conexao();
        string localDB = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\DB\";
       
        public void backup(SaveFileDialog saveFileDialog)
        {
            
            
            con.desconectarBD_Backup();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(saveFileDialog.FileName))
                {
                    System.IO.File.Delete(saveFileDialog.FileName);
                }

                ZipFile.CreateFromDirectory(localDB, saveFileDialog.FileName);
                
                MessageBox.Show("Backup Realizado");
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
        }
        public void restauraBackup(OpenFileDialog openFileDialog)
        {
            
            con.desconectarBD_Backup();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Directory.Exists(localDB))
                {
                    System.IO.Directory.Delete(localDB,true);
                }
                ZipFile.ExtractToDirectory(openFileDialog.FileName, localDB);
                MessageBox.Show("Backup Restaurado");
                Application.Restart();
               
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
        }
    }
}
