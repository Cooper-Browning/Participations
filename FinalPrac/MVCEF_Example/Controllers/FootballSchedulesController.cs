using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEF_Example.Models;

namespace MVCEF_Example.Controllers
{
    public class FootballSchedulesController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: FootballSchedules
        public ActionResult Index()
        {
            var homeGames = db.FootballSchedules.Where(x => x.IsHomeGame == true).ToList();
            var awayGames = db.FootballSchedules.Where(x => x.IsHomeGame == false).ToList();

            List<FootballSchedule> games = new List<FootballSchedule>();

            foreach (var x in db.FootballSchedules) //this does the same thing as the where stmts up above!!
            {
                if (x.IsHomeGame)
                {
                    games.Add(x);
                }
            }
            var firstFive = games.Take(5).OrderBy(x => x.Date).ToList();
            return View(db.FootballSchedules.ToList());
        }

        // GET: FootballSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballSchedule footballSchedule = db.FootballSchedules.Find(id);
            if (footballSchedule == null)
            {
                return HttpNotFound();
            }
            return View(footballSchedule);
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
