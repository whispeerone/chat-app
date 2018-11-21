namespace ChatAppCommandBackend.Models{
    public class Message : Entity{
        public string Text { get; set; }
        public virtual User Author { get; set; }
        public virtual Chat Chat { get; set; }
    }
}