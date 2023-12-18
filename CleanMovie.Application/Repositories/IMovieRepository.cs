using CleanMovie.Domain;

namespace CleanMovie.Application.Repositories;

// Data Access
public interface IMovieRepository
{
    List<Movie> GetAllMovies();
}