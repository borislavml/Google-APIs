namespace GmailParserConsoleClient
{
    public class MailAddress
    {
        public MailAddress(string email, string name)
        {
            this.Email = email;
            this.Name = name;
        }

        public string Email { get; set; }

        public string Name { get; set; }
    }
}
