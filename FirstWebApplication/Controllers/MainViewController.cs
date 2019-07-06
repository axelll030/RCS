using FirstWebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class MainViewController : Controller
    {
        // GET: MainView
        public ActionResult Index(int? id)
        {
            MainViewModel model = new MainViewModel();

            using (var db = new MovieModel())
            {
                model.Cinemas = db.Cinemas.OrderBy(c => c.Name).ToList();
                if (id.HasValue)
                {
                    model.Movies = db.Movies.Where(m => m.CinemaId == id)
                        .OrderBy(m => m.Title).ToList();
                }
                //vai konstruktora
                else
                {
                    model.Movies = new List<Movy>();
                }
            }
        }
    }
}