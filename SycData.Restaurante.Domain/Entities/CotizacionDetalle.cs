namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CotizacionDetalle")]
    public partial class CotizacionDetalle
    {
        [Key]
        public int IdCotizacionDetalle { get; set; }

        public int IdCotizacion { get; set; }

        public int IdProducto { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }

        public double Total { get; set; }

        public string Observacion { get; set; }

        public double Igv { get; set; }

        public double Descuento { get; set; }

        public int? DocumentoPago_IdDocumentoPago { get; set; }

        public string Estado { get; set; }

        public virtual Cotizacion Cotizacion { get; set; }

        public virtual DocumentoPago DocumentoPago { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
