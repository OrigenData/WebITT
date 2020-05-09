namespace Tareas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomGenero = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Resumen = c.String(),
                        UrlImagen = c.String(),
                        GeneroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Generoes", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GeneroId", "dbo.Generoes");
            DropIndex("dbo.Movies", new[] { "GeneroId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Generoes");
        }
    }
}
