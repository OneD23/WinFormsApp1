using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;

namespace WinFormsApp1
{
    /// <summary>
    /// Interaction logic for SendMail.xaml
    /// </summary>
    public partial class Mensaje
    {
        private string To;
        private string Subject;
        private string Body;

        private MailMessage mail;
        

        public void Enviar(string[] mensserger)
        {
            {
               
                    To = mensserger[0];
                    Subject = mensserger[1];
                    Body = mensserger[2];

                    mail = new MailMessage();
                    mail.To.Add(new MailAddress(this.To));
                    mail.From = new MailAddress("wmr2233@hotmail.com");
                    mail.Subject = Subject;
                    mail.Body = Body;
                    mail.IsBodyHtml = false;

                 

                    SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                    using (client)
                    {
                    client.Credentials = new System.Net.NetworkCredential("wmr2233@hotmail.com", "Wanderson33");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
                    MessageBox.Show("Mensaje enviado Exitosamente");
                
            }

        }

    }
}