using N37_HT1.Data.Models;

namespace N37_HT1.Interfaces;

public interface IEmailService
{
    IEnumerable<EmailMessage> GetMessages(IEnumerable<EmailTemplate> templates, IEnumerable<User> users);
    Task SendEmailsAsync(IEnumerable<EmailMessage> messages);
}

