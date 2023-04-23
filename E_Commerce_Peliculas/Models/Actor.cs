﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Peliculas.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relaciones
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
