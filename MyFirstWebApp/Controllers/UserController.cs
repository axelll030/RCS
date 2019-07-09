using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<Users> users = new List<Users>();

            using (var db = new Db())
            {
                users = db.Users.ToList();
            }
            return View(users);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Users user = null;

            using(var db = new Db())
            {
                user = db.Users.Find(id);
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(Users user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Db())
                {
                    Users oldUser = db.Users.Find(user.Id);

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
        public ActionResult Create(Users user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Db())
                {
                    user = db.Users.Add(new Users()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                    });

                    db.SaveChanges();
                }
                return RedirectToAction("Index", new { id = user.Id });
            }
            return View(user);
        }
    }
}