using System.Collections;
using System.Collections.Generic;

namespace ChatAppCommandBackend.Models{
    public class User : Entity{

        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string Email { get; protected set; }
        public int Age { get; protected set; }
        public string Nickname { get; protected set; }

        public virtual List<Message> Messages { get; protected set; }
        public virtual List<UserChat> UserChats { get; protected set; }

        public static User Create(string name, string surname, string email, int age, string nickname){
            return new User {
                Name = name,
                Surname = surname,
                Email = email,
                Age = age,
                Nickname = nickname
            };
        }

        public void ChangeAge(int age){
            this.Age = age;
        }

        public void ChangeNickname(string nickname){
            Nickname = nickname;
        }

    }
}