namespace ChatAppCommandBackend.DTO{
    public class UserDto{
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string Email { get; protected set; }
        public int Age { get; protected set; }
        public string Nickname { get; protected set; }
    }
}