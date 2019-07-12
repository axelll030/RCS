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
        public ActionResult Topics()
        {
            List<Topic> topics = new List<Topic>();
            using (var db = new News_DB())
            {
                topics = db.Topics.ToList();
            }
            return View(topics);
        }
        [HttpGet]
        public ActionResult Main()
        {
            List<News> news = new List<News>();
            using (var db = new News_DB())
            {
                news = db.News.OrderByDescending(d => d.Date).ToList();
            }
            return View(news);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult NewsText(int id)
        {
            using (var db = new News_DB())
            {
                News news = db.News.Find(id);
                return View(news);
            }
        }
    }
}