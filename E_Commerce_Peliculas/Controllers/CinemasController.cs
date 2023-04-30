using E_Commerce_Peliculas.Data;
using E_Commerce_Peliculas.Data.Services;
using E_Commerce_Peliculas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service;
        public CinemasController(ICinemaService service)
        {
            _service = service;
        }
        //En este ejemplo en vez de hacerlo como en Actors, lo vamos a hacer con un Async Methods
        //
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cine)
        {


            if (!ModelState.IsValid)
            {
                //foreach (var key in ModelState.Keys)
                //{
                //    var errors = ModelState[key].Errors;
                //    foreach (var error in errors)
                //    {
                //        Debug.WriteLine($"Error en la propiedad {key}: {error.ErrorMessage}");
                //    }
                //}
                return View(cine);
            }
            await _service.AddAsync(cine);
            return RedirectToAction(nameof(Index));

        }


        //GEt_ Actors details 1

        public async Task<IActionResult> Details(int id)
        {
            var detalles = await _service.GetByIdAsync(id);
            if (detalles == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(detalles);
            }
        }


        //Get: Actors/Create
        public async Task<IActionResult> Edit(int id)
        {
            var detalles = await _service.GetByIdAsync(id);
            if (detalles == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(detalles);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema cine)
        {
            if (!ModelState.IsValid)
            {

                return View(cine);
            }
            await _service.UpdateAsync(id, cine);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(data);
            }

            return View();
        }

        [HttpPost, ActionName("Delete")] //Para que el nombre sea igual Delete.
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            else
            {
                await _service.DeleteAsync(id);
            }

            return RedirectToAction(nameof(Index));

        }
    }
}

    