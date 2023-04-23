using E_Commerce_Peliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Peliculas.Data
{
    /// <summary>
    /// Clase AppDbContext que hereda de DbContext y representa el contexto de la base de datos de la aplicación.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Constructor de la clase AppDbContext que recibe las opciones de configuración del contexto de la base de datos.
        /// </summary>
        /// <param name="options">Objeto DbContextOptions<AppDbContext> que contiene las opciones de configuración del contexto.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            

           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
