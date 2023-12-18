using CleanMovie.Domain;
using CleanMovie.Application.Repositories;

namespace CleanMovie.Application.Services;
public class MovieService : IMovieService
{
    // Constructor Dependecy Injection
    private readonly IMovieRepository _movieRepository;
    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public List<Movie> GetAllMovies()
    {
        var movies = _movieRepository.GetAllMovies();
        return movies;
    }
}