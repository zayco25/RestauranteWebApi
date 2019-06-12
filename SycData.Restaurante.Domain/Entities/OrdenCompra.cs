namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenCompra")]
    public partial class OrdenCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCompra()
        {
            OrdenCompraDetalle = new HashSet<OrdenCompraDetalle>();
        }

        [Key]
        public int IdOrdenCompra { get; set; }

        public int IdProveedor { get; set; }

        public int IdTipoDocumento { get; set; }

        [StringLength(20)]
        public string Numero { get; set; }

        [StringLength(20)]
        public string Serie { get; set; }

        public DateTime FechaEmisión { get; set; }

        public DateTime FechaRegisto { get; set; }

        public int IdMoneda { get; set; }

        [StringLength(150)]
        public string Observación { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        public int? IdDocumentoPago { get; set; }

        public int? IdLocal { get; set; }

        public double TC { get; set; }

        public string Letras { get; set; }

        public decimal Total { get; set; }

        public double SubTotal { get; set; }

        public double Igv { get; set; }

        public bool IncluyeIGV { get; set; }

        public int Ncuotas { get; set; }

        public int IdFormaPago { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdAsesor { get; set; }

        public int? IdUsuarioAcepta { get; set; }

        public DateTime? FechaAceptacion { get; set; }

        public bool ConIgv { get; set; }

        public virtual Local Local { get; set; }

        public virtual Moneda Moneda { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual TipoDocumentoPago TipoDocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalle { get; set; }
    }
}
