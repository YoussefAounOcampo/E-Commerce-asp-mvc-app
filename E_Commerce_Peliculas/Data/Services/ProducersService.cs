using E_Commerce_Peliculas.Data.Base;
using E_Commerce_Peliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Data.Services
{

    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {

        public ProducersService(AppDbContext context) : base(context) { }
 
        
    }
}
