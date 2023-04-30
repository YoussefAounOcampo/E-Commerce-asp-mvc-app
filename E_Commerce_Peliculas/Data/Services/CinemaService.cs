using E_Commerce_Peliculas.Data.Base;
using E_Commerce_Peliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Data.Services
{

    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {

        public CinemaService(AppDbContext context) : base(context) { }
 
        
    }
}
