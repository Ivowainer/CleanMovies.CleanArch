using CleanMovie.Domain;

namespace CleanMovie.Application.Services;
public interface IMovieService
{
    List<Movie> GetAllMovies();
    Movie CreateMovie(Movie movie);
}