using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMovies();
        Task<bool> CreateMovie(Movie movie);
    }
}
