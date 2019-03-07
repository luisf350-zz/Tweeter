using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweeter.Models;
using Tweeter.Extensions;

namespace Tweeter.Controllers
{
    public class HomeController : Controller
    {
        private readonly TwitterDb _db;

        public HomeController()
        {
            _db = new TwitterDb();
        }

        public ActionResult Index()
        {
            List<Tweet> model = _db.Tweets.ToList();
            return View(model);
        }

        public ActionResult WeeklyTopFive()
        {
            var fecha = DateTime.Today.StartOfWeek(DayOfWeek.Monday);
            List<Tweet> model = (from lo in _db.Tweets
                                 orderby lo.Favs descending
                                 where lo.PostedDate >= fecha
                                 select lo).Take(5).ToList();

            return PartialView("_WeeklyTop", model);
        }

        public ActionResult TopFive()
        {
            List<Tweet> model = (from lo in _db.Tweets
                                 orderby lo.Favs descending
                                 select lo).Take(5).ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}