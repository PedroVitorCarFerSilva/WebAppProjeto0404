using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Modelo.Tabelas;
using Modelo.Cadastros;
using WebAppProjeto0404.Migrations;

namespace WebAppProjeto0404.Models
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS")
        {
            //Database.SetInitializer<EFContext>(
            //new DropCreateDatabaseIfModelChanges<EFContext>());
            Database.SetInitializer<EFContext>(new
            MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }
        public DbSet<Categorico> Categoricos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }

}