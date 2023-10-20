using System.Security.Cryptography;

namespace WebApplication2.Models
{
    public class MessageModel1
    {
        private string sender;
        private string recipient;
        private string contents;
        private string timestamp;

        public MessageModel1(string sender, string recipient, string contents, string timestamp)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.contents = contents;
            this.timestamp = timestamp;
        }
    }
}
