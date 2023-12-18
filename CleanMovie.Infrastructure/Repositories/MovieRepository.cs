using CleanMovie.Application.Repositories;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>(){
            new Movie {Id= 1, Name = "Aladin", Cost = 2},
            new Movie {Id= 2, Name = "Home Alone", Cost = 1}
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}