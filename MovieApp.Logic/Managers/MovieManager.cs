using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Logic.Managers
{
    /// <summary>
    /// FIlmu parvaldnieks
    /// </summary>
    public static class MovieManager
    {
        /// <summary>
        /// Pilns filmu saraksts
        /// </summary>
        /// <returns>Saraksts ar filmam</returns>
        public static List<User> GetMovies()
        {
            using (var db = new DB())
            {
                return db.Movies.OrderBy(m => m.Title).ToList();
            }
        }
        /// <summary>
        /// FIlmu atlase
        /// </summary>
        /// <param name="cinemaId"></param>
        /// <returns>Saraksts ar filmam</returns>
        public static List<User> GetMovies(int cinemaId)
        {
            using (var db = new DB())
            {
                return db.Movies.Where(m => m.CinemaId == cinemaId).OrderBy(m => m.Title).ToList();
            }
        }
        /// <summary>
        /// Filmas dzesana
        /// </summary>
        /// <param name="id">Filmas Id</param>
        public static void Delete(int id)
        {
            using (var db = new DB())
            {
                db.Movies.Remove(db.Movies.Find(id));

                db.SaveCHanges();
            }
        }
        /// <summary>
        /// Pierakstam jaunu filmu
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static Movies Create(Movies movie)
        {
            using (var db = new DB())
            {
                movie = db.Movies.Add(movie)

                db.SaveChanges();
                return movie;
            }
        }
        /// <summary>
        /// Filmu parametru maina
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static Movies Update(Movies movie)
        {
            using (var db = new DB())
            {
                var existing = db.Movies.Find(movie.Id);
                existing.Title = movie.Title;
                existing.Year = movie.Year;

                db.SaveChanges();
                return existing;
            }
        }
    }
}
