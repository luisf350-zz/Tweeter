using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweeter.Models;

namespace Tweeter.Controllers
{
    public class HomeController : Controller
    {
        private readonly TwitterDb _db;

        public ActionResult Index()
        {
            List<Tweet> model = _db.Tweets.ToList();
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
            if (_db == null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}