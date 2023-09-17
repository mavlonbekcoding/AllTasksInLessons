using N37_HT1.Data.Models;
using N37_HT1.Interfaces;

namespace N37_HT1.Service;

public class EmailService : IEmailService
{
    public IEnumerable<EmailMessage> GetMessages(IEnumerable<EmailTemplate> templates, IEnumerable<User> users)
    {
        var messages = new List<EmailMessage>();
        foreach (var user in users)
        {
            foreach (var template in templates)
            {
                messages.Add(new EmailMessage
                {
                    Subject = template.Subject,
                    Body = template.Body,
                    SenderAddress = "sender@example.com",
                    ReceiverAddress = "receiver@example.com"
                });
            }
        }
        return messages;
    }

    public async Task SendEmailsAsync(IEnumerable<EmailMessage> messages)
    {
        foreach (var message in messages)
        {
            Console.WriteLine($"Sending email to {message.ReceiverAddress}");
            Console.WriteLine($"Email to {message.ReceiverAddress} sent.");
        }
    }
}