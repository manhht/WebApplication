using System;
using System.ComponentModel;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

namespace WebApplication.Code
{
    public class EmailServiceProvider
    {
        public static string  SendMail(MimeMessage mimeMessage)
        {
            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("smtp.gmail.com", 587);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("automaticemail01@gmail.com", "tu1den10");

                  var result=  client.Send(mimeMessage);
                    client.Disconnect(true);
                    return result;
                }
            }
            catch (Exception ex)
            {
                return ". EX: " + ex.Message + ". " + ex?.InnerException?.InnerException?.Message;
            }

        }
    }
}