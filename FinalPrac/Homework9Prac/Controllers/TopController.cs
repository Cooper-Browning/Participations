using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework9Prac.Models;

namespace Homework9Prac.Controllers
{
    public class TopController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: Top
        public ActionResult Movies(int? number)
        {
           
            if (number == null)
            {
                var movies = db.Movies.Include(m => m.Director).OrderByDescending(x => x.gross).Take(10);
                return View(movies.ToList());
            }
            else
            {
                var movies = db.Movies.Include(m => m.Director).OrderByDescending(x => x.gross).Take((int)number);
                return View(movies.ToList());
            }
            
            
        }

        // GET: Top/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
