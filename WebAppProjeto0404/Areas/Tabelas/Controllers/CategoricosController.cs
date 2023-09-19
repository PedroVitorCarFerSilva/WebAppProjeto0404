using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto0404.Models;
using Modelo.Tabelas;
using Modelo.Cadastros;
using Servico.Tabelas;

namespace WebAppProjeto0404.Areas.Tabelas.Controllers
{
    public class CategoricosController : Controller
    {
        //private EFContext context = new EFContext();
        private CategoricoServico categoricoServico = new CategoricoServico();
        private ActionResult ObterVisaoCategoricoPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(
                HttpStatusCode.BadRequest);
            }
            Categorico categorico = categoricoServico.ObterCategoricoPorId((long)id);
            if (categorico == null)
            {
                return HttpNotFound();
            }
            return View(categorico);
        }
        private ActionResult GravarCategorico(Categorico categorico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoricoServico.GravarCategorico(categorico);
                    return RedirectToAction("Index");
                }
                return View(categorico);
            }
            catch
            {
                return View(categorico);
            }
        }
        // GET: Categoricos
        public ActionResult Index()
        {
            return View(categoricoServico.ObterCategoricosClassificadasPorNome());
        }
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorico categorico)
        {
            return GravarCategorico(categorico);
        }

        // GET: Edit
        public ActionResult Edit(long? id)
        {
            return ObterVisaoCategoricoPorId(id);
        }
        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorico categorico)
        {
            return GravarCategorico(categorico);
        }

        // GET: Details
        public ActionResult Details(long? id)
        {
            return ObterVisaoCategoricoPorId(id);
        }

        // GET: Delete
        public ActionResult Delete(long? id)
        {
            return ObterVisaoCategoricoPorId(id);
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            try
            {
                Categorico categorico = categoricoServico.EliminarCategoricoPorId(id);
                TempData["Message"] = "Categorico " + categorico.Nome.ToUpper() + " foi removida";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoricos
        /*
        private static IList<Categorico> categoricos = new List<Categorico>()
        {
            new Categorico() { CategoricoId = 1, Nome = "Notebooks"},
            new Categorico() { CategoricoId = 2, Nome = "Monitores"},
            new Categorico() { CategoricoId = 3, Nome = "Impressoras"},
            new Categorico() { CategoricoId = 4, Nome = "Mouses"},
            new Categorico() { CategoricoId = 5, Nome = "Desktops"}
        };
        public ActionResult Index()
        {
            return View(categoricos);
        }
        // GET: Categoricos
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorico categorico)
        {
            categorico.CategoricoId = categoricos.Select(m => m.CategoricoId).Max() + 1;
            categoricos.Add(categorico);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            return View(categoricos.Where(m => m.CategoricoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorico categorico)
        {
            categoricos.Remove(categoricos.Where(c => c.CategoricoId == categorico.CategoricoId).First());
            categoricos.Add(categorico);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(long id)
        {
            return View(categoricos.Where(m => m.CategoricoId == id).First());
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            return View(categoricos.Where(m => m.CategoricoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categorico categorico)
        {
            categoricos.Remove(
            categoricos.Where(c => c.CategoricoId == categorico.CategoricoId).First());
            return RedirectToAction("Index");
        }*/
    }
}