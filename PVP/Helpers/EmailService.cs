using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;

namespace PVP.Helpers
{
    public interface IEmailService
    {
        bool SendEmail(string to, string subject, string text);
    }

    public class EmailService : IEmailService
    {
        private readonly string mail;
        private readonly string pass;
        private readonly string host;
        private readonly int port;


        public EmailService()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            mail = configuration.GetValue<string>("Email:Name");
            pass = configuration.GetValue<string>("Email:Password");
            host = configuration.GetValue<string>("Email:Host");
            port = configuration.GetValue<int>("Email:Port");
        }

        // Siunciamas email
        public bool SendEmail(string to, string subject, string text)
        {
            try
            {
                // create email
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(mail));
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                email.Body = new TextPart(TextFormat.Html) { Text = text };

                // send email
                using var smtp = new SmtpClient();
                smtp.Connect(host, port, SecureSocketOptions.StartTls);
                smtp.Authenticate(mail, pass);
                smtp.Send(email);
                smtp.Disconnect(true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
