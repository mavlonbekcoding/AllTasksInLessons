using N37_HT1.Data.Models;
using N37_HT1.Interfaces;

namespace N37_HT1.Service;

public class EmailTemplateService : IEmailTemplateService
{
    public IEnumerable<EmailTemplate> GetTemplates(IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            yield return new EmailTemplate
            {
                Subject = GetSubject(user.UserStatus),
                Body = GetBody(user.UserStatus, user.FirstName)
            };
        }
    }

    private string GetSubject(Status userStatus)
    {
        if (userStatus == Status.Registered)
        {
            return "Welcome to our system";
        }
        else if (userStatus == Status.Deleted)
        {
            return "Account Deletion Notification";
        }
        else
        {
            return "Notification";
        }
    }

    private string GetBody(Status userStatus, string firstName)
    {
        if (userStatus == Status.Registered)
        {
            return $"Hi {firstName}, welcome to our system.";
        }
        else if (userStatus == Status.Deleted)
        {
            return $"Dear {firstName}, We are sorry to inform you that your account has been deleted from our system.";
        }
        else
        {
            return "Notification body goes here.";
        }
    }
}


