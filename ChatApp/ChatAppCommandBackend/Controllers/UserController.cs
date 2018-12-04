using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatAppCommandBackend.Commands.User;
using ChatAppCommandBackend.Context;
using ChatAppCommandBackend.Models;
using ChatAppCommandBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppCommandBackend.Controllers{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase{

        private readonly UserService _userService;
        
        public UserController(UserService userService){
            _userService = userService;
        }

        [HttpPost("createUser")]
        public int CreateUser(CreateUserCommand command){
            
            _userService.Create(command.Name, command.Surname, command.Email, command.Age, command.Nickname);
            
            return 1;
        }
    }
}