using ChatAppCommandBackend.DomainEvents.Misc;
using ChatAppCommandBackend.Models;

namespace ChatAppCommandBackend.DomainEvents.UserEvents{
    public abstract class UserUpdatedEvent : BaseDomainEvent{
        public int UserId{ get; protected set; }
    }
}