using Movies.App.Data.Models;

namespace Movies.App.Services
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        Movie? Get(int id);
        void Add(Movie movie);
    }
}
