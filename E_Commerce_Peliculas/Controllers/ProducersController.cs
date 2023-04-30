using E_Commerce_Peliculas.Data;
using E_Commerce_Peliculas.Data.Services;
using E_Commerce_Peliculas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace E_Commerce_Peliculas.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        //En este ejemplo en vez de hacerlo como en Actors, lo vamos a hacer con un Async Methods
        //
        public async Task<IActionResult> Index()
        {
            var data = await  _service.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
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
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));

        }


        //GEt_ Actors details 1

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(producerDetails);
            }
        }


        //Get: Actors/Create
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(producerDetails);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producer)
        {
            if (!ModelState.IsValid)
            {

                return View(producer);
            }
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(producerDetails);
            }

            return View();
        }

        [HttpPost, ActionName("Delete")] //Para que el nombre sea igual Delete.
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
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
