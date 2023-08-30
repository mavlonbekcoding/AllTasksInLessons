using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT2
{
    public class ChatMessage 
    {
        public Guid Id { get; set; }
        public DateTime SentTime {get;set;}
        public DateTime EditTime { get; set; }
        public string Content { get; set; }
    }
}
.