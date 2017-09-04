using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTechnology.View;

namespace BiblioTechnology

{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 2;
            }
            else
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Visible = false;
                timer.Stop();
            }
        }
        
    }
}
