namespace ChatAppCommandBackend.DomainEvents.UserEvents{
    public class UserNicknameUpdatedEvent : UserUpdatedEvent{
        
        public string Nickname { get; protected set; }

        public UserNicknameUpdatedEvent(int userId, string nickname){
            UserId = userId;
            Nickname = nickname;
        }
    }
}