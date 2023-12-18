using CleanMovie.Domain;

namespace CleanMovie.Application.Services;
public interface IMovieService
{
    List<Movie> GetAllMovies();
}