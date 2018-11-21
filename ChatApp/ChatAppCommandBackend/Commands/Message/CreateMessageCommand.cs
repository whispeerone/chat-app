namespace ChatAppCommandBackend.Commands.Message{
    public class CreateMessageCommand : Command{
        public int ChatId { get; set; }
        public int Text { get; set; }
    }
}