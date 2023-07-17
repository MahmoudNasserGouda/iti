namespace WebApplication1.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string subject, string body, string receiver, string receiverName);
    }
}
