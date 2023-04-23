using E_Commerce_Peliculas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        //En este ejemplo en vez de hacerlo como en Actors, lo vamos a hacer con un Async Methods
        //
        public async Task<IActionResult> Index()
        {
            var allProducers = await  _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
