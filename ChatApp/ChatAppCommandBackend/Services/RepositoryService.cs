using ChatAppCommandBackend.Context;
using Microsoft.EntityFrameworkCore;

namespace ChatAppCommandBackend.Services{
    public class RepositoryService<T> where T : class {

        private readonly AppDbContext _dbContext;

        public RepositoryService(AppDbContext dbContext){
            _dbContext = dbContext;
        }

        public T Add(T e){
            var inserted =  _dbContext.Add<T>(e);
            _dbContext.SaveChanges();

            return inserted.Entity;
        }
        
        

    }
}