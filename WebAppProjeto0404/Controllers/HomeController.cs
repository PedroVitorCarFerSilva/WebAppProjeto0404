using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto0404.Models;
using Modelo.Cadastros;
using Modelo.Tabelas;
using Servico.Cadastros;
using Servico.Tabelas;

namespace WebAppProjeto0404.Controllers
{
    public class HomeController : Controller
    {
        // private EFContext context = new EFContext();
        private ProdutoServico produtoServico = new ProdutoServico();
        private CategoricoServico categoricoServico = new CategoricoServico();
        private FabricanteServico fabricanteServico = new FabricanteServico();

        // GET: Home
        public ActionResult Index(long? FabId, long? CatId)
        {
            Home h = new Home();
            h.fabricante = fabricanteServico.ObterFabricantesClassificadosPorNome();
            h.categorico = categoricoServico.ObterCategoricosClassificadasPorNome();
            if (FabId != null)
            {
                h.filtro = "Fabricante";
                h.produtos = produtoServico.ObterProdutosClassificadosPorNome().Where(p => p.FabricanteId == FabId);
            }

            if (CatId != null)
            {
                h.filtro = "Categorico";
                h.produtos = produtoServico.ObterProdutosClassificadosPorNome().Where(p => p.CategoricoId == CatId);
            }
            return View(h);
        }
    }
}