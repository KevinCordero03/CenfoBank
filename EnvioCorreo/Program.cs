using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EnvioCorreo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("kcorderoa@ucenfotec.ac.cr", "TEST: TestEmailSendGrid");
            var subject = "TEST: TestEmailSendGrid";
            var to = new EmailAddress("kcorderoa@ucenfotec.ac.cr", "Kevin Cordero");
            var plainTextContent = "Probando el envio de correo";
            var htmlContent = "<strong>Envio de Correo</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
