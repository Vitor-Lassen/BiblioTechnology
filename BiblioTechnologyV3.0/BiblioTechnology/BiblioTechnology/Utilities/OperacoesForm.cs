using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BiblioTechnology
{
    class OperacoesForm
    {
        public void chamarFrm(Form frmAtual, Form frmChamado)
        {
            
                frmChamado.MdiParent = frmAtual;
            
                frmChamado.Show();
               // frmChamado.WindowState = FormWindowState.Minimized;
                frmChamado.WindowState = FormWindowState.Maximized;
           
        }
       

        public void correcaoInicialForm( Form frm)
        {
              frm.ControlBox = false;
              frm.Width += 1;
              frm.WindowState = FormWindowState.Maximized;
        }
        public void retornarFrm(Form frm)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            {
                
                frm.WindowState = FormWindowState.Minimized;
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.Width += 1;
                frm.Width -= 1;
            }
        }
       
    }
}
