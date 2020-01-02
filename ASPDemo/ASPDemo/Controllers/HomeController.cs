using ASPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ASPDemo.Controllers
{
    public class HomeController : Controller
    {
        GameContext db = new GameContext();

        public ActionResult Index()
        {
            return View(db.Games);
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.GameId = id;
            return View();
        }

        [HttpPost]
        public string Buy(GamePurchase gamePurchase)
        {
            gamePurchase.Date = DateTime.Now;
            db.Purchases.Add(gamePurchase);
            db.SaveChanges();
            return $"Thank you, {gamePurchase.Person}, for purchase!";
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Game game = db.Games.Find(id);

            if (game != null)
            {
                return View(game);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Game game)
        {
            db.Entry(game).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Game game)
        {
            db.Entry(game).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Game g = db.Games.Find(id);

            if (g == null)
            {
                return HttpNotFound();
            }

            return View(g);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmation(int id)
        {
            Game g = db.Games.Find(id);

            if (g == null)
            {
                return HttpNotFound();
            }

            db.Games.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}