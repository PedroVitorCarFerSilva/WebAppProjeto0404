using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppProjeto0404.Models
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }
        public DbSet<Categorico> Categoricos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }

}