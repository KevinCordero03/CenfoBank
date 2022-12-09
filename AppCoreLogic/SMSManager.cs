using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace AppCoreLogic
{
    public class SMSManager
    {
        public void SendWelcomeSms(Customer c)
        {
            var message = "Welcome " + c.Name + " to Arbank App";
            PushSms(c.phone, message);
        }

        private void PushSms(string phoneNumber, string text)
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = "ACeb70443e04f46940d280ec2715f63389";
            string authToken = "d0e26f9655feb5f4f99b34d67572ac23";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: text,
                from: new Twilio.Types.PhoneNumber("+19405319570"),
                to: new Twilio.Types.PhoneNumber("+50686991121")
            );
        }
    }
}
