using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace EnvioMensajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = "ACeb70443e04f46940d280ec2715f63389";
            string authToken = "d0e26f9655feb5f4f99b34d67572ac23";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Test from C#.",
                from: new Twilio.Types.PhoneNumber("++14248424307"),
                to: new Twilio.Types.PhoneNumber("+89964992")
            );

            Console.WriteLine(message.Sid);

        }
    }
}
