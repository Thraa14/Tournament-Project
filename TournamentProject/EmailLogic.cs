using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TournamentProject
{
    public static class EmailLogic
    {
        //public static void SendingEmail(List<string> to , List<string> bcc,  string subject , string body)
        //{
        //    MailAddress FromMailAddress = new MailAddress(GlobalConfig.AppKeyLogin("SenderEmail"), GlobalConfig.AppKeyLogin("SenderName"));
        //    MailMessage mail = new MailMessage();
        //    foreach(string email in to)
        //    {
        //        mail.To.Add(email);
        //    }
        //    foreach (string email in bcc)
        //    {
        //        mail.Bcc.Add(email);
        //    }
        //    mail.From = FromMailAddress;
        //    mail.Subject = subject;
        //    mail.Body = body;
        //    mail.IsBodyHtml = true;

        //    SmtpClient Client = new SmtpClient();
        //    Client.Send(mail);
        //}

        //public static void SendingEmail(string to , string subject , string body)
        //{
        //    SendingEmail(new List<string> { to }, new List<string>(), subject, body);
        //}
      
    } 
}
