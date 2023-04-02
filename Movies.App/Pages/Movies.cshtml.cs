using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.App.Data;
using Movies.App.Data.Models;
using Movies.App.Services;

namespace Movies.App.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        private IMoviesService _service;
        public MoviesModel(IMoviesService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            Movies = _service.GetAll();
        }
    }
}
