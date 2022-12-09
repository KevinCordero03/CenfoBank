using DTO_POJOS;
using POJO_DTOs;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppCoreLogic
{
    public class EmailManager
    {
        public void SendWelcomeEmail(Customer c, Account a)
        {
            var subject = "Welcome " + c.Name + " to Arbank App";
            var body = "Your UBAN account is: " + a.UBAN;
            if (c.email != null)
                PushEmail(c.email, subject, body);
            else
                throw new Exception("Email cannot be null");

        }

        private string PushEmail(string email, string subjectText, string body)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("arbank@gmail.com", "Arbank App");
            var subject = subjectText;
            var to = new EmailAddress(email);
            var htmlContent = "<strong>" + body + "</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlContent);
            var response = client.SendEmailAsync(msg).Result;

            if (response != null)
                return "ok";
            else
                return "ERR";
        }
    }
}
