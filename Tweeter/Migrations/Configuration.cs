namespace Tweeter.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using Tweeter.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TwitterDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TwitterDb context)
        {
            context.Users.AddOrUpdate(new User
            {
                Id = Guid.NewGuid(),
                UserName = "@luisf350",
                FriendlyName = "Luis Fernando Ramirez",
                CreationDate = DateTime.Now,
                LastSignIn = DateTime.Now,
                Tweets = new List<Tweet>
                {
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Tweet de prueba",
                        Favs = 5,
                        PostedDate = DateTime.Today.AddDays(-1),
                        Retweets = 3
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Otro Tweet de prueba",
                        Favs = 7,
                        PostedDate = DateTime.Today.AddDays(-2),
                        Retweets = 5
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Tercer Tweet",
                        Favs = 2,
                        PostedDate = DateTime.Today.AddDays(-3),
                        Retweets = 10
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Cuarto Tweet",
                        Favs = 11,
                       PostedDate = DateTime.Today.AddDays(-10),
                        Retweets = 30
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Quinto Tweet",
                        Favs = 165,
                       PostedDate = DateTime.Today.AddDays(-4),
                        Retweets = 45
                    }
                }
            });

            context.Users.AddOrUpdate(new User
            {
                Id = Guid.NewGuid(),
                UserName = "@AlexO",
                FriendlyName = "Alex Ortiz",
                CreationDate = DateTime.Now,
                LastSignIn = DateTime.Now,
                Tweets = new List<Tweet>
                {
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Soy un marica",
                        Favs = 5,
                        PostedDate = DateTime.Today.AddDays(-1),
                        Retweets = 3
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Soy casacrrabias",
                        Favs = 7,
                        PostedDate = DateTime.Today.AddDays(-2),
                        Retweets = 5
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Peleo diario",
                        Favs = 2,
                        PostedDate = DateTime.Today.AddDays(-3),
                        Retweets = 10
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Nada Me gusta",
                        Favs = 11,
                       PostedDate = DateTime.Today.AddDays(-10),
                        Retweets = 30
                    },
                    new Tweet
                    {
                        Id = Guid.NewGuid(),
                        Text = "Gonorrea ome gonorrea",
                        Favs = 165,
                       PostedDate = DateTime.Today.AddDays(-4),
                        Retweets = 45
                    }
                }
            });
        }
    }
}
