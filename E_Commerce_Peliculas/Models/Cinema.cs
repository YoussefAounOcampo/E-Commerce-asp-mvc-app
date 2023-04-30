using E_Commerce_Peliculas.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Peliculas.Models
{
    public class Cinema : IEntityBaseRepository
    {
        [Key]
        public int Id { get; set; }
       
       
        [Display (Name ="Logo")]
        [Required(ErrorMessage = "El Logo es obligatoria")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre introducido no es válido")]
        public string Name { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "No es válido")]
        public string Description { get; set; }

        //Relaciones
        public List<Movie> ? Movies { get; set; }
    }

}
