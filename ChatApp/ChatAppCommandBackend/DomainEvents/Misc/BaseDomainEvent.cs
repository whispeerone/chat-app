using System;

namespace ChatAppCommandBackend.DomainEvents.Misc{
    public class BaseDomainEvent{
        public DateTime Date { get; } = new DateTime();
    }
}