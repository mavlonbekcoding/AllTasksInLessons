using N37_HT1.Interfaces;
namespace N37_HT1.Service;

public class NotificationManagementService : INotificationManagementService
{
    private readonly IUserService _userService;
    private readonly IEmailTemplateService _emailTemplateService;
    private readonly IEmailService _emailService;

    public NotificationManagementService(
        IUserService userService,
        IEmailTemplateService emailTemplateService,
        IEmailService emailService)
    {
        _userService = userService;
        _emailTemplateService = emailTemplateService;
        _emailService = emailService;
    }

    public async Task NotifyUsersAsync()
    {
        var users = _userService.GetUsers();
        var templates = _emailTemplateService.GetTemplates(users);
        var messages = _emailService.GetMessages(templates, users);

        await _emailService.SendEmailsAsync(messages);
    }
}

