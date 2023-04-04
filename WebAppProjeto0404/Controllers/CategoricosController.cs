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
    }
}