namespace SycData.Restaurante.Infra.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd22dsd2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comanda", "FechaRegistro", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comanda", "FechaRegistro", c => c.DateTime(nullable: false));
        }
    }
}
