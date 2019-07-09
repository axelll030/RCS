using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApp.Controllers
{
    public class NewsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Topic> topics = new List<Topic>();
            using (var db = new News_DB())
            {
                topics = db.Topics.ToList();
            }
            return View(topics);
        }
    }
}