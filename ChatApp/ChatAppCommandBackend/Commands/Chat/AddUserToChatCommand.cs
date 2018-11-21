namespace ChatAppCommandBackend.Commands{
    public class AddUserToChatCommand : Command{
        public int ChatId { get; set; }
        public int UserId { get; set; }
    }
}