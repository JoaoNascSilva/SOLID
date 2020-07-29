using System.Net.Mail;

namespace Aplicando_SOLID_NaPratica
{
    public static class EmailService
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Send(string to, string from, string subject, string message)
        {
            var mail = new MailMessage(to, from);
            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = message;
            smtpClient.Send(mail);
        }
    }
}