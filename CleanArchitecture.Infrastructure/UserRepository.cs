using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _dbContext;

        public UserRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateUser(User? user)
        {
            await _dbContext.Users!.AddAsync(user!);
            return await _dbContext.SaveChangesAsync() >= 0 ? true : false;
        }

        public async Task<User?> GetUsersByName(string userName)
        {
            return await _dbContext.Users!.FirstOrDefaultAsync(u => u.userName == userName);
        }

        public async Task<bool> UserAlreadyExists(string userName)
        {
            return await _dbContext.Users!.AnyAsync(u => u.userName == userName);
        }
    }
}
