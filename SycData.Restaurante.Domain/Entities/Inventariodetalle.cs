namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventariodetalle")]
    public partial class Inventariodetalle
    {
        [Key]
        [Column("InventarioDetalle")]
        public int InventarioDetalle1 { get; set; }

        public int IdInventario { get; set; }

        public int Idproducto { get; set; }

        public double Cantidad { get; set; }

        public double StockActual { get; set; }

        public double Diferencia { get; set; }

        public virtual Inventario Inventario { get; set; }
    }
}
