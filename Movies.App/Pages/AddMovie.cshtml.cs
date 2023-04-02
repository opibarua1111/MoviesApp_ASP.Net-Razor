using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.App.Data;
using Movies.App.Data.Models;
using Movies.App.Services;

namespace Movies.App.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public int Rate { get; set; }

        //public string? Description { get; set; } not required field
        [BindProperty]
        public string Description { get; set; }

        private IMoviesService _service;
        public AddMovieModel(IMoviesService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            //Title = "Welcome";
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var movie = new Movie()
            {
                Title = Title,
                Rate = Rate,
                Description = Description
            };
            _service.Add(movie);

            return Redirect("Movies");
        }
    }
}
