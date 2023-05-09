using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto0404.Models;

namespace WebAppProjeto0404.Controllers
{
    public class CategoricosController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Categoricos
        public ActionResult Index()
        {
            return View(
                context.Categoricos.OrderBy(c => c.Nome)
            );
        }
        public ActionResult Create()
        {
            return View();
        }

        // GET: Categoricos/Edit/1
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorico categorico = context.Categoricos.Find(id);
            if (categorico == null)
            {
                return HttpNotFound();
            }
            return View(categorico);
        }

        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorico categorico = context.Categoricos.Find(id);
            if (categorico == null)
            {
                return HttpNotFound();
            }
            return View(categorico);
        }

        // POST: Categoricos/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Categorico categorico = context.Categoricos.Find(id);
            context.Categoricos.Remove(categorico);
            context.SaveChanges();
            TempData["Message"] = "Categorico \"" + categorico.Nome + "\" foi removido";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorico categorico = context.Categoricos.Find(id);
            if (categorico == null)
            {
                return HttpNotFound();
            }
            return View(categorico);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorico categorico)
        {
            if (ModelState.IsValid)
            {
                context.Entry(categorico).State = EntityState.Modified;
                context.SaveChanges();
                TempData["Message"] = "Categorico \"" + categorico.Nome + "\" foi modificado";
                return RedirectToAction("Index");
            }
            return View(categorico);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorico categorico)
        {
            context.Categoricos.Add(categorico);
            context.SaveChanges();
            TempData["Message"] = "Categprico \"" + categorico.Nome + "\" foi registrado";
            return RedirectToAction("Index");
        }
    }
}