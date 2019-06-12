namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenEnvioDetalle")]
    public partial class OrdenEnvioDetalle
    {
        [Key]
        public int IdOrdenEnvioDetalle { get; set; }

        public int IdOrdenEnvio { get; set; }

        public int IdProducto { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }

        public double Total { get; set; }

        public virtual OrdenEnvio OrdenEnvio { get; set; }
    }
}
