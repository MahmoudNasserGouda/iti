using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace WebApplication1.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient _mailClient;
        private readonly string _host;
        private readonly int _port;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _sender;
        public EmailService(IConfiguration config)
        {
            _mailClient = new SmtpClient();
            var section = config.GetSection("EmailSettings");
            _host = section["Host"];
            _port = int.Parse(section["Port"]);
            _userName = section["Username"];
            _password = section["Password"];
            _sender = section["Sender"];
        }
        public async Task SendEmailAsync(string subject, string body, string receiver, string receiverName)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("BookLogist", _sender));
            email.To.Add(new MailboxAddress(receiverName, receiver));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Plain)
            {
                Text = body
            };

            _mailClient.Connect(_host, _port, SecureSocketOptions.StartTls);

            _mailClient.Authenticate(_userName, _password);

            await _mailClient.SendAsync(email);
            _mailClient.Disconnect(true);
        }
    }
}
