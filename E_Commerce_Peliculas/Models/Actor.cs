using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Peliculas.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "La foto de perfil es obligatoria")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre introducido no es válido")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "La biografía es obligatoria")]

        public string Bio { get; set; }

        //Relaciones
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
