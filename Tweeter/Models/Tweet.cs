using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweeter.Models
{
    public class Tweet
    {
        public Guid Id { get; set; }

        public User Author { get; set; }

        public string Text { get; set; }

        public DateTime PostedDate { get; set; }

        public int Retweets { get; set; }

        public int Favs { get; set; }

        public ICollection<Tweet> Replies { get; set; }
    }
}