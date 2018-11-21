namespace ChatAppCommandBackend.DomainEvents.UserEvents{
    public class UserNameUpdatedEvent : UserUpdatedEvent{
        
        public string Name { get; protected set; }
        public string Surname { get; protected set; }

        public UserNameUpdatedEvent(int userId, string name, string surname){
            UserId = userId;
            Name = name;
            Surname = surname;
        }
    }
}