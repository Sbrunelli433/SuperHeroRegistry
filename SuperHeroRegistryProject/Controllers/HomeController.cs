using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroRegistryProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Create a Super Hero on this page!";

            return View("/Views/SuperHeroes/Create.cshtml");
        }

        public ActionResult Delete()
        {
            ViewBag.Message = "delete a super hero on this page";

            return View("/Views/SuperHeroes/Delete.cshtml");
        }

        public ActionResult Edit()
        {
            ViewBag.Message = "here's the list";

            return View("/Views/SuperHeroes/Edit.cshtml");
        }

    }
}