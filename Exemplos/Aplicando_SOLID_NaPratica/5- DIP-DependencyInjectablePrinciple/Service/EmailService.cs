using Aplicando_SOLID_NaPratica.DIP_DependencyInjectablePrinciple.Interface;
using System.Net.Mail;

namespace Aplicando_SOLID_NaPratica.DIP_DependencyInjectablePrinciple.Service
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string from, string to, string subject, string message)
        {
            var mail = new MailMessage(from, to);

            var customerSendEmail = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = message;
            customerSendEmail.Send(mail);
        }
    }
}