using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto0404.Models;

namespace WebAppProjeto0404.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Home
        public ActionResult Index(long? FabId, long? CatId)
        {
            Home h = new Home();
            h.fabricante = context.Fabricantes.OrderBy(c => c.Nome);
            h.categorico = context.Categoricos.OrderBy(c => c.Nome);
            if (FabId != null)
            {
                h.filtro = "Fabricante";
                h.produtos = context.Produtos.Where(p => p.FabricanteId == FabId).OrderBy(c => c.Nome);
            }

            if (CatId != null)
            {
                h.filtro = "Categorico";
                h.produtos = context.Produtos.Where(p => p.CategoricoId == CatId).OrderBy(c => c.Nome);
            }
            return View(h);
        }
    }
}