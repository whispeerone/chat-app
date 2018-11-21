using ChatAppCommandBackend.DomainEvents.Misc;
using ChatAppCommandBackend.Models;

namespace ChatAppCommandBackend.DomainEvents.UserEvents{
    public class UserCreatedEvent : BaseDomainEvent{
        public User User { get; protected set; }

        public UserCreatedEvent(User user){
            User = user;
        }
    }
}