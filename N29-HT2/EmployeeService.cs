using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace N29_HT2
{
    public class EmployeeService
    {
        public async Task HireAsync(string firstName, string lastName)
        {
            var employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName
            };

            await SendConfirmationEmail(employee, "sultonbek.rakhimov.recovery@gmail.com", "yunusbekahmedov62@gmail.com");
            CreateEmploymentContract(employee);
            await SendWelcomeEmail(employee, "sultonbek.rakhimov.recovery@gmail.com", "yunusbekahmedov62@gmail.com");
            SendOfficePoliciesEmail(employee, "sultonbek.rakhimov.recovery@gmail.com", "yunusbekahmedov62@gmail.com");
        }

        private async Task SendConfirmationEmail(Employee employee, string fromEmail, string toEmail)
        {
            string subject = "Confirm Your Email Address";
            string body = $"Dear {employee.FirstName},\n\n" +
                          "Thank you for joining the team. To start your journey, we need to first confirm your email address. " +
                          "Please click on the following link to confirm your email address:\n\n" +
                          "Confirmation Link: [Insert Link Here]\n\n" +
                          "If you received this email mistakenly, please ignore this email.\n\n" +
                          "Thank you";

            await SendEmailAsync(fromEmail, toEmail, subject, body);
        }

        private void CreateEmploymentContract(Employee employee)
        {
            string fileName = $"{employee.FirstName}_{employee.LastName}_employment_contract.docs";
            string contractText = $"Employment Contract for {employee.FirstName} {employee.LastName}\n\n" +
                                  "This is to confirm your employment with our company.";

            File.WriteAllText(fileName, contractText);
        }

        private async Task SendWelcomeEmail(Employee employee, string fromEmail, string toEmail)
        {
            string subject = "Welcome to [Your Company]";
            string body = $"Dear {employee.FirstName},\n\n" +
                          "We are thrilled to welcome you! We are excited to have you on board and look forward to working with you.\n\n" +
                          "As a new member of our team, we want to make sure you have everything you need to get started. " +
                          "Please let us know if you have any questions or need any assistance.\n\n" +
                          "We wish you all the best in your new role and look forward to your contributions to our team.\n\n" +
                          "Best regards";

            await SendEmailAsync(fromEmail, toEmail, subject, body);
        }

        private void SendOfficePoliciesEmail(Employee employee, string fromEmail, string toEmail)
        {
            string subject = "Office Policies and Guidelines";
            string body = $"Dear {employee.FirstName},\n\n" +
                          "As a member of our team, it is important that you are aware of our office policies and guidelines. " +
                          "These policies are designed to ensure a safe and productive work environment for everyone.\n\n" +
                          "Please take a moment to review the attached document, which outlines our policies and guidelines. " +
                          "If you have any questions or concerns, please do not hesitate to reach out to us.\n\n" +
                          "Thank you for your cooperation and adherence to our policies.\n\n" +
                          "Best regards";

            SendEmail(fromEmail, toEmail, subject, body);
        }

        private async Task SendEmailAsync(string fromEmail, string toEmail, string subject, string body)
        {
            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587; // Gmail SMTP port raqami
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, "szabguksrhwsbtie"); // Elektron pochta parolingiz
                smtpClient.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = subject,
                    Body = body
                };

                mailMessage.To.Add(toEmail);

                await smtpClient.SendMailAsync(mailMessage);
            }
        }

        private void SendEmail(string fromEmail, string toEmail, string subject, string body)
        {
            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587; // Gmail SMTP port raqami
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, "szabguksrhwsbtie"); // Elektron pochta parolingiz
                smtpClient.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = subject,
                    Body = body
                };

                mailMessage.To.Add(toEmail);

                smtpClient.Send(mailMessage);
            }
        }
    }
}
