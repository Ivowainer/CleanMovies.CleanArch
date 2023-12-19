using CleanMovie.Application.Repositories;
using CleanMovie.Domain;
using CleanMovie.Infrastructure.Data;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _movies;

        public MovieRepository(MovieDbContext movies)
        {
            _movies = movies;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movies.Movies.Add(movie);
            _movies.SaveChanges();

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movies.Movies.ToList();

        }

    }
}