using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tweeter.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string FriendlyName { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastSignIn { get; set; }

        public virtual ICollection<Tweet> Tweets { get; set; }

        //public ICollection<User> Followers { get; set; }

        //public ICollection<User> Following { get; set; }
    }
}