using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            LogoURL = "img/firstcinema.png",
                            Description = "Description for the first cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            LogoURL = "img/secondcinema.jpg",
                            Description = "Description for the second cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            LogoURL = "img/thirdcinema.png",
                            Description = "Description for the third cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            LogoURL = "img/fourthcinema.png",
                            Description = "Description for the fourth cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            LogoURL = "img/fifthcinema.png",
                            Description = "Description for the fifth cinema."
                        },
                    });
                    context.SaveChanges();
                }

                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "Some bio for actor 1",
                            ProfilePictureURL = "img/firstactor.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Some bio for actor 2",
                            ProfilePictureURL = "img/secondactor.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Some bio for actor 3",
                            ProfilePictureURL = "img/thirdactor.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "Some bio for actor 4",
                            ProfilePictureURL = "img/fourthactor.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "Some bio for actor 5",
                            ProfilePictureURL = "img/fifthactor.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "Some bio for producer 1",
                            ProfilePictureURL = "img/firstproducer.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "Some bio for producer 2",
                            ProfilePictureURL = "img/secondproducer.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "Some bio for producer 3",
                            ProfilePictureURL = "img/thirdproducer.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "Some bio for producer 4",
                            ProfilePictureURL = "img/fourthproducer.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "Some bio for producer 5",
                            ProfilePictureURL = "img/fifthproducer.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Titanic",
                            Description = "Drama movie about biggest ship ever built",
                            Price = 40,
                            ImageURL = "img/firstmovie.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Spider Man",
                            Description = "Action movie about man that bitted by spider",
                            Price = 35,
                            ImageURL = "img/secondmovie.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "King Kong",
                            Description = "Action movie about biggest monkey ever seen",
                            Price = 66,
                            ImageURL = "img/thirdmovie.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "Horror movie about biggest ghost ever seen",
                            Price = 40,
                            ImageURL = "img/fourthmovie.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 4,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Adults film",
                            Description = "Just some porn for good ppl",
                            Price = 40,
                            ImageURL = "img/fifthmovie.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 5,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Porn
                        },
                    });
                    context.SaveChanges();
                }

                //actors_movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>() 
                    {
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 1
                        },
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 3
                        },
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 5
                        },
                        new Actor_Movie()
                        {
                            MovieId = 2,
                            ActorId = 2
                        },
                        new Actor_Movie()
                        {
                            MovieId = 2,
                            ActorId = 4
                        },
                        new Actor_Movie()
                        {
                            MovieId = 2,
                            ActorId = 3
                        },
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 1
                        },
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 4
                        },
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 5
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 2
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 3
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 5
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 1
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 2
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 5
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
