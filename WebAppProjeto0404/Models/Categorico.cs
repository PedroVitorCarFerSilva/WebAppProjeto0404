using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto0404.Models
{
    public class Categorico
    {

        public long CategoricoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}