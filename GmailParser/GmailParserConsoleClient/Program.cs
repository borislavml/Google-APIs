using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GmailParserConsoleClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gmailParser = new GmailParser();
            // Run this method once to authorize your application
            // gmailParser.AuthorizeApplication();

            GmailService service = gmailParser.GetGmailService();

            string userId = "me"; // special param for identifying your email
            string query = "from:emilia@softuni.bg subject:Проверяващи на изпитни работи по MVC ASP.NET after:20150808";
            string savePath = @"D:\gmail-inbox.txt";
            // get all messages meeting query crteria 
            List<Message> messages = gmailParser.ListMessages(service, userId, query);

            foreach (var message in messages)
            {
                Message currentMessage = gmailParser.GetMessage(service, userId, message.Id);
                if (currentMessage.Payload.Parts != null && currentMessage.Payload.Parts.Count > 0)
                {
                    foreach (var part in currentMessage.Payload.Parts)
                    {
                        if (part.Body.Data != null)
                        {
                            string base64String = part.Body.Data;
                            base64String = base64String.Replace('-', '+');
                            base64String = base64String.Replace('_', '/');
                            byte[] messageBodyData = Convert.FromBase64String(base64String);
                            string decodedMessageString = Encoding.UTF8.GetString(messageBodyData);
                            File.AppendAllText(savePath, decodedMessageString);
                        }
                    }
                }
            }
        }
    }
}
