namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentoPagoDetalle")]
    public partial class DocumentoPagoDetalle
    {
        [Key]
        public int IdDocumentoPagoDetalle { get; set; }

        public int IdDocumentoPago { get; set; }

        public int IdProducto { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }

        public double Total { get; set; }

        public string Observacion { get; set; }

        public double Igv { get; set; }

        public double Descuento { get; set; }

        public virtual DocumentoPago DocumentoPago { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
