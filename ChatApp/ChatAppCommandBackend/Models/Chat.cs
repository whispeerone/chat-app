using System.Collections.Generic;

namespace ChatAppCommandBackend.Models{
    public class Chat : Entity{
        public string Title { get; set; }
        public virtual List<Message> Messages { get; set; }
        public virtual List<UserChat> UserChats { get; set; }
    }
}