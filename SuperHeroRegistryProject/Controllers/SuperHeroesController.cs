using FluentNHibernate.Conventions.Inspections;
using SuperHeroRegistryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroRegistryProject.Controllers
{
    public class SuperHeroesController : Controller
    {
        ApplicationDbContext db;
        public SuperHeroesController()
        {
            db = new ApplicationDbContext();
        }
        // GET: SuperHeroes
        public ActionResult Index()
        {
           
            return View(db.SuperHeroes.ToList());
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details()
        {
            return View("Details");
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                db.SuperHeroes.Add(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperHero superHero = db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return HttpNotFound();
            }
            return View(superHero);
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,AlterEgoName,PrimaryAblity,SecondaryAbility,Catchphrase")] SuperHero superHero)
        {

                    // TODO: Add update logic here
                    if (ModelState.IsValid)
                    {
                    db.Entry(superHero).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");

                    }
            return View(superHero);
            

        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperHero superHero = db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return HttpNotFound();
            }
            return View(superHero);
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                SuperHero superHero = db.SuperHeroes.Find(id);
                db.SuperHeroes.Remove(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
