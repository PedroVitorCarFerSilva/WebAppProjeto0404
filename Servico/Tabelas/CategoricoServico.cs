using Modelo.Tabelas;
using Persistencia.DAL.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Tabelas
{
    public class CategoricoServico
    {
        private CategoricoDAL categoricoDAL = new CategoricoDAL();
        public IQueryable<Categorico> ObterCategoricosClassificadasPorNome()
        {
            return categoricoDAL.ObterCategoricosClassificadasPorNome();
        }
        public Categorico ObterCategoricoPorId(long id)
        {
            return categoricoDAL.ObterCategoricoPorId(id);
        }
        public void GravarCategorico(Categorico categorico)
        {
            categoricoDAL.GravarCategorico(categorico);
        }
        public Categorico EliminarCategoricoPorId(long id)
        {
            Categorico categorico = categoricoDAL.ObterCategoricoPorId(id);
            categoricoDAL.EliminarCategoricoPorId(id);
            return categorico;
        }
    }
}