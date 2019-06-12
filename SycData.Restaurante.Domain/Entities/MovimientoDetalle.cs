namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientoDetalle")]
    public partial class MovimientoDetalle
    {
        [Key]
        public int IdMovimientoDetalle { get; set; }

        public int IdMovimiento { get; set; }

        public int IdProducto { get; set; }

        public double Cantidad { get; set; }

        public virtual Movimiento Movimiento { get; set; }
    }
}
