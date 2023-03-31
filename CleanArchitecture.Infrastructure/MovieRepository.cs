using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DBContext _dbContext;

        public MovieRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<bool> CreateMovie(Movie movie)
        {
            await _dbContext.Movies!.AddAsync(movie);
            return await _dbContext.SaveChangesAsync() >= 0 ? true : false;            
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await _dbContext.Movies!.ToListAsync();
        }
    }
}
