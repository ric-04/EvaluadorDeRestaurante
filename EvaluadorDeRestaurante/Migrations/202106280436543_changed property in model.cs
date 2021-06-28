namespace EvaluadorDeRestaurante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedpropertyinmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurantes", "Puntaje", c => c.Int(nullable: false));
            DropColumn("dbo.Restaurantes", "Nota");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurantes", "Nota", c => c.Int(nullable: false));
            DropColumn("dbo.Restaurantes", "Puntaje");
        }
    }
}
