using CleanMovie.Domain.Entities;
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
        return _movieRepository.GetAllMovies();
    }

    public Movie CreateMovie(Movie movie)
    {
        return _movieRepository.CreateMovie(movie);
    }
}