namespace SycData.Restaurante.Infra.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rest : DbMigration
    {
        public override void Up()
        {
       
            
            CreateTable(
                "dbo.Comanda",
                c => new
                    {
                        IdComanda = c.Int(nullable: false, identity: true),
                        IdMozo = c.Int(nullable: false),
                        IdMesa = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        IdOperacion = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdUsuario = c.Int(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        Estado = c.String(),
                        NComanda = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdComanda)
                .ForeignKey("dbo.Operacion", t => t.IdOperacion, cascadeDelete: true)
                .Index(t => t.IdOperacion);
            
            CreateTable(
                "dbo.ComandaDetalle",
                c => new
                    {
                        IdDetalleComanda = c.Int(nullable: false, identity: true),
                        IdComanda = c.Int(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observacion = c.String(),
                        Combo = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        IdProductoCombo = c.Int(nullable: false),
                        CantidadCombo = c.Int(nullable: false),
                        IdConcepto = c.Int(),
                    })
                .PrimaryKey(t => t.IdDetalleComanda)
                .ForeignKey("dbo.Comanda", t => t.IdComanda, cascadeDelete: true)
                .Index(t => t.IdComanda);
             
            
 
            
            CreateTable(
                "dbo.Mesa",
                c => new
                    {
                        IdMesa = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Int(nullable: false),
                        Ocupado = c.Int(nullable: false),
                        IdNivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMesa)
                .ForeignKey("dbo.Nivel", t => t.IdNivel, cascadeDelete: true)
                .Index(t => t.IdNivel);
            
            CreateTable(
                "dbo.Nivel",
                c => new
                    {
                        IdNivel = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 150, unicode: false),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdNivel);
            
        }
        
        public override void Down()
        {
           
        }
    }
}
