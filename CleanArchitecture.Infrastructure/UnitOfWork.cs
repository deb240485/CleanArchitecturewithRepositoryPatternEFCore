using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _dbContext;
        public UnitOfWork(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IMovieRepository _movieRepository => new MovieRepository(_dbContext) ;

        public IUserRepository _userRepository => new UserRepository(_dbContext);
    }
}
