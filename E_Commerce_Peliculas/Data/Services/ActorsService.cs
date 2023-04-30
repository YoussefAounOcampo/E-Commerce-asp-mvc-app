using E_Commerce_Peliculas.Data.Base;
using E_Commerce_Peliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Data.Services
{

    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) : base(context) { }
 
        
    }
}
