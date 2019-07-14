using NewsApp.Models;
using NewsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApp.Controllers
{
    public class NewsController : Controller
    {

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

        private List<Topic> TopicList()
        {
            List<Topic> topics = new List<Topic>();
            using (var db = new News_DB())
            {
                topics = db.Topics.ToList();
            }
            return topics;
        }

        [HttpGet]
        public ActionResult Topics(int id)
        {
            var model = new MyModel();
            model.Topics = TopicList();
            model.News = GetTopics(id);
            model.Topic = GetTopic(id);

            return View(model);
        }

        private List<News> GetTopics(int id)
        {
            List<News> news = new List<News>();
            using (var db = new News_DB())
            {
                news = db.News.Where(x => x.TopicId == id).ToList();
            }
            return news;
        }

        private Topic GetTopic(int id)
        {
            using (var db = new News_DB())
            {
                Topic topic = db.Topics.Find(id);
                return topic;
            }
        }

        [HttpGet]
        public ActionResult NewsText(int id)
        {
            var model = new NewsComment();
            model.News = GetNewsText(id);
            model.Comments = GetComments(id);
            model.NewComment = new Comment()
            {
                NewsId = id
            };

            return View(model);

        }
        private News GetNewsText(int id)
        {
            using (var db = new News_DB())
            {
                News news = db.News.Find(id);
                return news;
            }
        }

        private List<Comment> GetComments(int id)
        {
            List<Comment> comments = new List<Comment>();
            using (var db = new News_DB())
            {
                comments = db.Comments.Where(x => x.NewsId == id).ToList();
            }
            return comments;
        }
        [HttpPost]
        public ActionResult NewComment(Comment newComment)
        {
            if (ModelState.IsValid)
            {
                using (var db = new News_DB())
                {
                    newComment = db.Comments.Add(new Models.Comment()
                    {
                        Name = newComment.Name,
                        Comments = newComment.Comments,
                        NewsId = newComment.NewsId
                    });
                    db.SaveChanges();
                }
            }
            return RedirectToAction("NewsText", new { id = newComment.NewsId });
        }
        [HttpGet]
        public ActionResult DeleteComment(int commentId, int newsId)
        {
            using (var db= new News_DB())
            {
                db.Comments.Remove(db.Comments.Find(commentId));

                db.SaveChanges();
            }
            return RedirectToAction("NewsText", new { id = newsId });
        }

        [HttpGet]
        public ActionResult NewNews()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult NewNews(News news)
        {
            if (ModelState.IsValid)
            {
                using(var db = new News_DB())
                {
                    news = db.News.Add(new Models.News()
                    {
                        Name = news.Name,
                        Author = news.Author,
                        Article = news.Article,
                        Date = news.Date,
                        Picture = "/Content/Placeholder.png",
                        TopicId = news.TopicId
                    });
                    db.SaveChanges();
                }
                return RedirectToAction("NewsText", new { id = news.Id });
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteNews(int newsId)
        {
            using (var db = new News_DB())
            {
                db.Comments.RemoveRange(db.Comments.Where(c => c.NewsId == newsId));
                db.News.Remove(db.News.Find(newsId));

                db.SaveChanges();
            }
            return RedirectToAction("Main");
        }
    }
}