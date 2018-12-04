using ChatAppCommandBackend.DTO;
using ChatAppCommandBackend.Models;

namespace ChatAppCommandBackend.Services{
    public class UserService{

        private readonly RepositoryService<User> _repositoryService;

        public UserService(RepositoryService<User> repositoryService){
            _repositoryService = repositoryService;
        }

        public UserDto Create(string name, string surname, string email, int age, string nickname){
            var newUser = User.Create(name, surname, email, age, nickname);

            _repositoryService.Add(newUser);
            
            return null;
        }
        
        
        
    }
}