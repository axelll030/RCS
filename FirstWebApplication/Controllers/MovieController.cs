using FirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            // GET: User
            List<Movie> movies = new List<Movie>();
            using (var db = new MovieDB())
            {
                movies = db.Movies.ToList();
            }
            return View(movies);
        }  
    }
}