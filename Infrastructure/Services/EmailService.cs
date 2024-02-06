using System.Net.Mail;
using System.Net;

namespace Infrastructure.Services
{
    public class EmailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly MailAddress _fromAddress;

        public EmailService(string host, int port, bool enableSsl, string username, string password, string fromEmail, string displayName)
        {
            _fromAddress = new MailAddress(fromEmail, displayName);
            _smtpClient = new SmtpClient
            {
                Host = host,
                Port = port,
                EnableSsl = enableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(username, password)
            };
        }

        public void SendEmail(string toEmail, string subject, string body)
        {
            var toAddress = new MailAddress(toEmail);
            using (var message = new MailMessage(_fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                _smtpClient.Send(message);
            }
        }
    }
}
