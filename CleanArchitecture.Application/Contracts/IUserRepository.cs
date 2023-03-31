using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts
{
    public interface IUserRepository
    {
        Task<User?> GetUsersByName(string userName);
        Task<bool> UserAlreadyExists(string userName);
        Task<bool> CreateUser(User? user);
    }
}
