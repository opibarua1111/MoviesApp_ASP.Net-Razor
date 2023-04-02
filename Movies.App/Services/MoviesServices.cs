using Movies.App.Data;
using Movies.App.Data.Models;

namespace Movies.App.Services
{
    public class MoviesServices : IMoviesService
    {
        private ApplicationDbContext _context;
        public MoviesServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public Movie? Get(int id) => _context.Movies.FirstOrDefault(x => x.Id == id);

        public List<Movie> GetAll() => _context.Movies.ToList();
    }
}
