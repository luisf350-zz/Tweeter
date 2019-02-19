using System.Data.Entity;

namespace Tweeter.Models
{
    public class TwitterDb : DbContext
    {
        #region Properties

        public DbSet<User> Users { get; set; }

        public DbSet<Tweet> Tweets { get; set; }

        #endregion

        #region Constructor

        public TwitterDb() : base("DefaultConnection")
        {

        }

        #endregion
    }
}