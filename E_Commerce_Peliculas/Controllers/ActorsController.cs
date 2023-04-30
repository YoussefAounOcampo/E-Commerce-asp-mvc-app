using E_Commerce_Peliculas.Data;
using E_Commerce_Peliculas.Data.Services;
using E_Commerce_Peliculas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace E_Commerce_Peliculas.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Actor actor)
        {
            Debug.WriteLine("ProfilePictureURL: " + actor.ProfilePictureURL);
            Debug.WriteLine("FullName: " + actor.FullName);
            Debug.WriteLine("Bio: " + actor.Bio);

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
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }


        //GEt_ Actors details 1

        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(actorDetails);
            }
        }


        //Get: Actors/Create
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(actorDetails);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
               
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(actorDetails);
            }

            return View();
        }

        [HttpPost, ActionName("Delete")] //Para que el nombre sea igual Delete.
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
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
