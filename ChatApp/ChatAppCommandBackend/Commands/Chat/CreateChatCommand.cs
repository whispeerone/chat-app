namespace ChatAppCommandBackend.Commands{
    public class CreateChatCommand : Command{
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}