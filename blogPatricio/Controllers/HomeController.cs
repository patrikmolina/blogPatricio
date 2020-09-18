using blogPatricio.Models;
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
            DbActions dbacc = new DbActions();
            return View(dbacc.getAllPost());
        }
        public ActionResult NewPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewPost(FormCollection collection)
        {
            DbActions dbacc = new DbActions();
            Post po = new Post
            {
                FechaCreacion = DateTime.Parse(collection["Fecha"].ToString()),
                Titulo = collection["Titulo"],
                Contenido = collection["Contenido"],
                Imagen = collection["Imagen"],
                Categoria = collection["Categoria"]
            };
            dbacc.Create(po);
            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(int Id)
        {
            DbActions dbacc = new DbActions();
            Post po = dbacc.getPost(Id);
            return View(po);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            DbActions dbacc = new DbActions();
            Post po = new Post
            {
                Id = int.Parse(collection["Id"].ToString()),
                Titulo = collection["Titulo"],
                Contenido = collection["Contenido"],
                Imagen = collection["Imagen"],
                Categoria = collection["Categoria"]
            };
            dbacc.Edit(po);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DbActions dbacc = new DbActions();
            dbacc.Delete(id);
            return RedirectToAction("Index");
        }

       

    }
}