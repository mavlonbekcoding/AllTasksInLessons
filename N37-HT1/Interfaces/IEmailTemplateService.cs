using N37_HT1.Data.Models;

namespace N37_HT1.Interfaces;

public interface IEmailTemplateService
{
    IEnumerable<EmailTemplate> GetTemplates(IEnumerable<User> users);
}

