using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto0404.Models;

namespace WebAppProjeto0404.Controllers
{
    public class CategoricosController : Controller
    {
        private static IList<Categorico> categoricos = new List<Categorico>()
        {
            new Categorico(){ Nome = "Gabinete", CategoricoId = 1},
            new Categorico(){ Nome = "Mouse", CategoricoId = 2},
            new Categorico(){ Nome = "Teclado", CategoricoId = 3},
            new Categorico(){ Nome = "Monitor", CategoricoId = 4},
            new Categorico(){ Nome = "Dildo", CategoricoId = 5}
        };
        // GET: Categoricos
        public ActionResult Index()
        {
            return View(categoricos);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(long id)
        {
            return View(categoricos.Where(m => m.CategoricoId == id).First());
        }
        public ActionResult Details(long id)
        {
            return View(categoricos.Where(m => m.CategoricoId == id).First());
        }
        public ActionResult Delete(long id)
        {
            return View(categoricos.Where(t => t.CategoricoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categorico categorico)
        {
            categoricos.Remove(categoricos.Where(t => t.CategoricoId == categorico.CategoricoId).First());
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorico categorico)
        {
            categorico.CategoricoId = categoricos.Select(m => m.CategoricoId).Max() + 1;
            categoricos.Add(categorico);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorico categorico)
        {
            categoricos.Remove(categoricos.Where(c => c.CategoricoId == categorico.CategoricoId).First());
            categoricos.Add(categorico);
            return RedirectToAction("Index");
        }
    }

}