namespace WebAppProjeto0404.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoricoes",
                c => new
                    {
                        CategoricoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoricoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        CategoricoId = c.Long(),
                        FabricanteId = c.Long(),
                        NomeArquivo = c.String(),
                        TamanhoArquivo = c.Long(nullable: false),
                        LogotipoMimeType = c.String(),
                        Logotipo = c.Binary(),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Categoricoes", t => t.CategoricoId)
                .ForeignKey("dbo.Fabricantes", t => t.FabricanteId)
                .Index(t => t.CategoricoId)
                .Index(t => t.FabricanteId);
            
            CreateTable(
                "dbo.Fabricantes",
                c => new
                    {
                        FabricanteId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.FabricanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "FabricanteId", "dbo.Fabricantes");
            DropForeignKey("dbo.Produtoes", "CategoricoId", "dbo.Categoricoes");
            DropIndex("dbo.Produtoes", new[] { "FabricanteId" });
            DropIndex("dbo.Produtoes", new[] { "CategoricoId" });
            DropTable("dbo.Fabricantes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Categoricoes");
        }
    }
}
