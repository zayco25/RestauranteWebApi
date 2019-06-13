namespace SycData.Restaurante.Infra.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd22dsd233 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroPedido",
                c => new
                    {
                        IdRegistroPedido = c.Int(nullable: false, identity: true),
                        IdMesa = c.Int(nullable: false),
                        PDescuento = c.Decimal(precision: 18, scale: 2),
                        Descuento = c.Decimal(precision: 18, scale: 2),
                        IdPersonal = c.Int(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        Previo = c.String(),
                        Cuenta = c.Int(nullable: false),
                        NPersonas = c.Int(nullable: false),
                        Cliente = c.String(),
                        IdOperacion = c.Int(nullable: false),
                        IdMesaAnterior = c.Int(),
                        FechaCaja = c.DateTime(nullable: false),
                        Tipo = c.String(),
                        IdTurno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRegistroPedido)
                .ForeignKey("dbo.Mesa", t => t.IdMesa, cascadeDelete: true)
                .Index(t => t.IdMesa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroPedido", "IdMesa", "dbo.Mesa");
            DropIndex("dbo.RegistroPedido", new[] { "IdMesa" });
            DropTable("dbo.RegistroPedido");
        }
    }
}
