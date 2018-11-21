namespace ChatAppCommandBackend.Commands.User{
    public class CreateUserCommand : Command{
    	public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Nickname { get; set; }    
    }
}