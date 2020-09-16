using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogPatricio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Post()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(new Post());
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            return RedirectToAction("Index");
        }

    }
}