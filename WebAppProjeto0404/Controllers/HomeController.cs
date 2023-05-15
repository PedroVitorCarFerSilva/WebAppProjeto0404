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
        public ActionResult Index()
        {
            Home h = new Home();
            h.fabricante = context.Fabricantes.OrderBy(c => c.Nome);
            h.categorico = context.Categoricos.OrderBy(c => c.Nome);

            return View(h);
        }
    }
}