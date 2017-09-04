using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BiblioTechnology.Utilities
{
    class Email
    {
        public void enviarEmail(string para, string titulo, string mensagem)
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add(para);
                message.Subject = titulo;
                message.From = new System.Net.Mail.MailAddress("bibliotechnology.suporte@gmail.com");
                message.Body = mensagem;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("bibliotechnology.suporte@gmail.com", "bibliotechnologyv3.0");
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show( "E-mail enviado com sucesso!\nVerifique sua caixa de email", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
               MessageBox.Show("Não foi possivel enviar o email tente novamente!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
