using FirstWebApplication.Models;
using System;
using MovieApp.Logic.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<MovieModel> movies = new List<MovieModel>();

            movies = MovieManager.GetMovies().Select(m => new MovieModel()
            {
                Id = m.Id,
                CinemaId = m.CinemaId,
                Title = m.Title,
                Year = m.Year,
            }).ToList();

            return View(users);
        }
        [HttpGet]//so metodi var izmantot tikai datu sanemsanai
        public ActionResult Edit(int id)
        {
            User user = null;
            using (var db = new DB())
            {
                user = db.Users.Find(id);
            }

            return View(user);
        }//bloks prieks lietotaja bazes attelosanas/\
        [HttpPost]//so metodi var izmantot tikai datu nosutisanai
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DB()) //pieslegums pie datubazes
                {
                    User oldUser = db.Users.Find(user.Id);

                    oldUser.FirstName = user.FirstName;
                    oldUser.LastName = user.LastName;

                    db.SaveChanges();
                }

            }
            return View(user);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DB())
                {
                    user = db.Users.Add(new Models.User()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                    });

                    db.SaveChanges();
                }

                return RedirectToAction("Index", new { id = user.Id });
            }
            return View();
        }
    }
}