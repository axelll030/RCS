using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class CinemaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Cinema> cinemas = new List<Cinema>();
            using(var db = new MovieDB())
            {
                cinemas = db.Cinemas.OrderBy(c => c.Name).ToList();
            }

            return View(cinemas);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Cinema cinema = null;//pievienosana
            if (id.HasValue)//redigesana
            {
                using (var db = new MovieDB())
                {
                    cinema = db.Cinemas.First(c => c.Id == id);
                }
            }
            else
            {
                cinema = new Cinema();//atversies nuksa forma pievienosanai
            }

            return View(cinema);//forma ar sarakstu
        }
        [HttpPost]
        public ActionResult Edit(Cinema cinema) //viss objekts parametros
        {
            if (ModelState.IsValid)
            {
                using(var db = new MovieDB())
                {
                    if(cinema.Id != 0)
                    {
                        var existing = db.Cinemas.Find(cinema.Id);
                        existing.Name = cinema.Name;
                        existing.Adress = cinema.Adress;
                    }
                    else
                    {
                        db.Cinemas.Add(new Cinema()
                        {
                            Name = cinema.Name,
                            Adress = cinema.Adress,
                        });
                    }

                    db.SaveChanges();
                }
            }

            return View(cinema);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using(var db = new MovieDB())
            {
                //vispirms dzes filmas
                db.Movies.RemoveRange(db.Movies.Where(m => m.CinemaId == id));
                //tad kinoteatrus
                db.Cinemas.Remove(db.Cinemas.Find(id));

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}