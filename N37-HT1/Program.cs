using N37_HT1.Service;

var userService = new UserService();
var emailTemplateService = new EmailTemplateService();
var emailService = new EmailService();
var notificationManagementService = new NotificationManagementService(
    userService, emailTemplateService, emailService);

await notificationManagementService.NotifyUsersAsync();