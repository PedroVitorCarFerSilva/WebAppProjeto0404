using Modelo.Cadastros;
using Modelo.Tabelas;
using Persistencia.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.Tabelas
{
    public class CategoricoDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Categorico> ObterCategoricosClassificadosPorNome()
        {
            return context.Categoricos.OrderBy(b => b.Nome);
        }
    }
}
