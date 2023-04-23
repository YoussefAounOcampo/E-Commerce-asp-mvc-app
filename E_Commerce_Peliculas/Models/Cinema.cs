using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Peliculas.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display (Name ="Logo Cine")]
        public string Logo { get; set; }
        [Display(Name = "Nombre Cine")]

        public string Name { get; set; }
        [Display(Name = "Descripción")]

        public string Description { get; set; }

        //Relaciones
        public List<Movie> Movies { get; set; }
    }

}
