namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenCompraDetalle")]
    public partial class OrdenCompraDetalle
    {
        [Key]
        public int IdOrdenCompraDetalle { get; set; }

        public int IdOrdenCompra { get; set; }

        public int IdProducto { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }

        public double Total { get; set; }

        public string Observacion { get; set; }

        public double Igv { get; set; }

        public double Descuento { get; set; }

        public string Estado { get; set; }

        public virtual OrdenCompra OrdenCompra { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
