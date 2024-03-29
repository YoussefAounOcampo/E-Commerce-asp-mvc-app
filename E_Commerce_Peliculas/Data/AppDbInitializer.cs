﻿using E_Commerce_Peliculas.Models;
using System.Net.NetworkInformation;

namespace E_Commerce_Peliculas.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo= "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description= "This is the description of the first cinema"
                        },
                         new Cinema()
                        {
                            Name="Cinema 2",
                            Logo= "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description= "This is the description of the second cinema"
                        },
                          new Cinema()
                        {
                            Name="Cinema 3",
                            Logo= "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description= "This is the description of the third cinema"
                        },
                           new Cinema()
                        {
                            Name="Cinema 4",
                            Logo= "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description= "This is the description of the fourth cinema"
                        },
                            new Cinema()
                        {
                            Name="Cinema 5",
                            Logo= "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description= "This is the description of the fith cinema"
                        },

                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first Actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second Actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third Actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth Actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth Actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                    //Producers
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first Producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second Producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the third Producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the fourth Producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the fifth Producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                        context.SaveChanges();

                    }
                    //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name ="Life",
                            Description = "This is the Life Movie Description",
                            Price= 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId=3,
                            ProducerId=3,
                            MovieCategory = Enums.MovieCategory.Documentary

                        },
                        new Movie()
                        {
                            Name ="The Shawshank Redemtion",
                            Description = "This is the The Shawshank Redemtion Movie Description",
                            Price= 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory = Enums.MovieCategory.Accion

                        },
                        new Movie()
                        {
                           Name ="Ghost",
                            Description = "This is the Ghost Movie Description",
                            Price= 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId=4,
                            ProducerId=4,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                           Name ="Race",
                            Description = "This is the Race Movie Description",
                            Price= 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId=1,
                            ProducerId=2,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name ="Scoob",
                            Description = "This is the Scoob Movie Description",
                            Price= 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId=3,
                            ProducerId=3,
                            MovieCategory = Enums.MovieCategory.Cartoon
                        },
                         new Movie()
                        {
                            Name ="Cold Soles",
                            Description = "This is the Cold Soles Movie Description",
                            Price= 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(4),
                            EndDate = DateTime.Now.AddDays(21),
                            CinemaId=1,
                            ProducerId=5,
                            MovieCategory = Enums.MovieCategory.Drama
                        }
                    });
                        context.SaveChanges();

                    }
                    //Actors & Movies
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                        {
                            new Actor_Movie()
                            {
                                ActorId=1,
                                MovieId=1
                            },
                            new Actor_Movie()
                            {
                                ActorId=3,
                                MovieId=1
                            },
                            new Actor_Movie()
                            {
                                ActorId=1,
                                MovieId=2
                            },
                            new Actor_Movie()
                            {
                                ActorId=4,
                                MovieId=2
                            },
                            new Actor_Movie()
                            {
                                ActorId=1,
                                MovieId=3
                            },
                            new Actor_Movie()
                            {
                                ActorId=2,
                                MovieId=3
                            },
                            new Actor_Movie()
                            {
                                ActorId=5,
                                MovieId=3
                            },
                            new Actor_Movie()
                            {
                                ActorId=2,
                                MovieId=4
                            },
                            new Actor_Movie()
                            {
                                ActorId=3,
                                MovieId=4
                            },
                            new Actor_Movie()
                            {
                                ActorId=4,
                                MovieId=4
                            },new Actor_Movie()
                            {
                                ActorId=2,
                                MovieId=5
                            },new Actor_Movie()
                            {
                                ActorId=3,
                                MovieId=5
                            },new Actor_Movie()
                            {
                                ActorId=4,
                                MovieId=5
                            },new Actor_Movie()
                            {
                                ActorId=5,
                                MovieId=5
                            },new Actor_Movie()
                            {
                                ActorId=3,
                                MovieId=6
                            },new Actor_Movie()
                            {
                                ActorId=4,
                                MovieId=6
                            },new Actor_Movie()
                            {
                                ActorId=5,
                                MovieId=6
                            },

                        });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
