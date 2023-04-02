using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.App.Data;
using Movies.App.Data.Models;
using Movies.App.Services;

namespace Movies.App.Pages
{
    public class MovieModel : PageModel
    {
        public Movie? Movie { get; set; }

        private IMoviesService _service;
        public MovieModel(IMoviesService service)
        {
            _service = service;
        }
        public void OnGet( int id)
        {
            Movie = _service.Get(id);
        }
    }
}
