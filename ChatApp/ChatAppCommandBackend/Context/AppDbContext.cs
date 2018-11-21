using ChatAppCommandBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAppCommandBackend.Context{
    public class AppDbContext : DbContext{
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }


        public AppDbContext(DbContextOptions options) : base(options){
            
        }
    }
}