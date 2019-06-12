namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            CotizacionDetalle = new HashSet<CotizacionDetalle>();
            DocumentoPagoDetalle = new HashSet<DocumentoPagoDetalle>();
            OrdenCompraDetalle = new HashSet<OrdenCompraDetalle>();
            ProductoAlmacen = new HashSet<ProductoAlmacen>();
        }

        [Key]
        public int IdProducto { get; set; }

        public string Descripcion { get; set; }

        public string Abreviatura { get; set; }

        public double Precio { get; set; }

        public double Costo { get; set; }

        public int IdUnidadMedida { get; set; }

        public int IdCategoria { get; set; }

        public int IdSubCategoria { get; set; }

        public string RutaImagen { get; set; }

        public string CodigoSunat { get; set; }

        public bool Inventariable { get; set; }

        public bool MostrarVenta { get; set; }

        public bool Cortesia { get; set; }

        public int Estado { get; set; }

        public bool SinIgv { get; set; }

        public bool Compuesto { get; set; }

        public int IdMoneda { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionDetalle> CotizacionDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoPagoDetalle> DocumentoPagoDetalle { get; set; }

        public virtual Moneda Moneda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalle { get; set; }

        public virtual SubCategoria SubCategoria { get; set; }

        public virtual UnidadMedida UnidadMedida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoAlmacen> ProductoAlmacen { get; set; }
    }
}
