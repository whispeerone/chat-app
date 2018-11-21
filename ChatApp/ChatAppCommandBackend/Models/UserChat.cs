namespace ChatAppCommandBackend.Models{
    public class UserChat : Entity{
        public User User { get; set; }
        public Chat Chat { get; set; }
    }
}