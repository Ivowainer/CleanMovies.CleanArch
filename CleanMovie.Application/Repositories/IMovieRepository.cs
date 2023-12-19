using CleanMovie.Domain.Entities;

namespace CleanMovie.Application.Repositories;

// Data Access
public interface IMovieRepository
{
    List<Movie> GetAllMovies();
    Movie CreateMovie(Movie movie);
}