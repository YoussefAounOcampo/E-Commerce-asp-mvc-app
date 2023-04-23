using E_Commerce_Peliculas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        //En este ejemplo en vez de hacerlo como en Actors, lo vamos a hacer con un Async Methods
        //
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n =>n.Cinema).OrderBy(n =>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
