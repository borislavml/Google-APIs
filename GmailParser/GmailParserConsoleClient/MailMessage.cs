namespace GmailParserConsoleClient
{
    public class MailMessage
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public MailAddress From { get; set; }
    }
}
