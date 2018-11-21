namespace ChatAppCommandBackend.Commands{
    public class DeleteUserFromChatCommand : Command{
        public int ChatId { get; set; }
        public int UserId { get; set; }
    }
}