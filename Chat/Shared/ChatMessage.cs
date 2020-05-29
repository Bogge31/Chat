using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Shared
{
    public class ChatMessage
    {
        public string From { get; set; }
        public string Message { get; set; }
        public DateTime At { get; set; }
    }
}
