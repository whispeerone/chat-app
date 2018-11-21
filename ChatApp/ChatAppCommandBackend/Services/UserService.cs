using ChatAppCommandBackend.DTO;
using ChatAppCommandBackend.Models;

namespace ChatAppCommandBackend.Services{
    public class UserService{

        private readonly RepositoryService<User> _repositoryService;

        public UserService(RepositoryService<User> repositoryService){
            _repositoryService = repositoryService;
        }

        public UserDto Create(){
            return null;
        }
    }
}