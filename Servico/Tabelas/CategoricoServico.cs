using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Tabelas;
using Persistencia.DAL.Tabelas;

namespace Servico.Tabelas
{
    public class CategoriaServico
    {
        private CategoricoDAL categoricoDAL = new CategoricoDAL();
        public IQueryable<Categorico> ObterCategoricosClassificadasPorNome()
        {
            return categoricoDAL.ObterCategoricosClassificadasPorNome();
        }
    }
}
