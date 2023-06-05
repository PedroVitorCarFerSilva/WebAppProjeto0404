using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto0404.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }
        public long? CategoriaId { get; set; }
        public long? FabricanteId { get; set; }
        public Categorico Categorico { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}