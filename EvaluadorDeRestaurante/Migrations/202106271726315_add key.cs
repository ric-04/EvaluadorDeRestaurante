namespace EvaluadorDeRestaurante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addkey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurantes",
                c => new
                    {
                        IdRestaurante = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        Nota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRestaurante);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurantes");
        }
    }
}
