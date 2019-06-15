using FirstWebApplication.Models;
using System;
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
            List<User> users = new List<User>();
            using (var db = new DB())
            {
                users = db.Users.ToList();
            }

            return View(users);
        }
    }
}