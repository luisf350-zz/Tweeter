namespace Tweeter.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
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
                        PostedDate = DateTime.Now,
                        Retweets = 3
                    }
                }
            });
        }
    }
}
