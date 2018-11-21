using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatAppCommandBackend.Commands.User;
using ChatAppCommandBackend.Context;
using ChatAppCommandBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppCommandBackend.Controllers{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase{

        private AppDbContext _dbContext;

        public UserController(AppDbContext dbContext){
            _dbContext = dbContext;
        }

        [HttpPost("createUser")]
        public int CreateUser(CreateUserCommand command){
            
            User newUser = Models.User.Create(command.Name, command.Surname, command.Email, command.Age, command.Nickname);

            var inserted = _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
            
            return inserted.Entity.Id;
        }
    }
}