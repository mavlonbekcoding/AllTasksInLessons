using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2._1
{
    public class ChatMessage : AuditableEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int chatId { get; set; }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Id.GetHashCode();
            hash = hash * 23 + Subject.GetHashCode();
            hash = hash * 23 + Message.GetHashCode();
            hash = hash * 23 + chatId.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ChatMessage other = (ChatMessage)obj;
            return Id == other.Id &&
                   Subject == other.Subject &&
                   Message == other.Message &&
                    chatId == other.chatId;
        }
        public override string ToString()
        {
            return $"Id: {Id}Subject: {Subject} Message: {Message} ChatId: {chatId}";
        }
    }
}
