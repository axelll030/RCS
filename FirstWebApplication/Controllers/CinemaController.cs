using FirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class CinemaController : Controller
    {
        // GET: Cinema
        public ActionResult Cinema()
        {
            List<Cinema> cinemas = new List<Cinema>();
            using (var db = new MovieDB())
            {
                cinemas = db.Cinemas.ToList();
            }
            return View(cinemas);
        }
    }
}