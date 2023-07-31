using Modelo.Tabelas;
using Persistencia.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.Tabelas
{
    public class CategoricoDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Categorico> ObterCategoricosClassificadasPorNome()
        {
            return context.Categoricos.OrderBy(b => b.Nome).Include(c => c.Produtos);
        }
        public Categorico ObterCategoricoPorId(long id)
        {
            return context.Categoricos.Where(c => c.CategoricoId == id).Include("Produtos.Fabricante").First();
        }
        public void GravarCategorico(Categorico categorico)
        {
            if (categorico.CategoricoId == 0)
            {
                context.Categoricos.Add(categorico);
            }
            else
            {
                context.Entry(categorico).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Categorico EliminarCategoricoPorId(long id)
        {
            Categorico categorico = ObterCategoricoPorId(id);
            context.Categoricos.Remove(categorico);
            context.SaveChanges();
            return categorico;
        }
    }
}