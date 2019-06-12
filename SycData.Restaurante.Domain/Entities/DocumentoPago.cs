namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentoPago")]
    public partial class DocumentoPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentoPago()
        {
            CotizacionDetalle = new HashSet<CotizacionDetalle>();
            DocumentoPagoDetalle = new HashSet<DocumentoPagoDetalle>();
        }

        [Key]
        public int IdDocumentoPago { get; set; }

        public int? IdCliente { get; set; }

        public int IdTipoDocumento { get; set; }

        [StringLength(20)]
        public string Numero { get; set; }

        [StringLength(20)]
        public string Serie { get; set; }

        public DateTime FechaEmisión { get; set; }

        public int IdMoneda { get; set; }

        [StringLength(150)]
        public string Observación { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        public int? IdLocal { get; set; }

        public double TC { get; set; }

        public string Letras { get; set; }

        public double Total { get; set; }

        public double SubTotal { get; set; }

        public double Igv { get; set; }

        public bool IncluyeIGV { get; set; }

        public DateTime? FechaRegisto { get; set; }

        public int? IdCotizacion { get; set; }

        public string CodigoRespuesta { get; set; }

        public string Hashcdr { get; set; }

        public string Hashcpe { get; set; }

        public int DocumentoEnviado { get; set; }

        public string MensajeSunat { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public int? IdProveedor { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public int? IdFormaPago { get; set; }

        public int? IdPersonal { get; set; }

        public int? DocumentoInterno { get; set; }

        public int? IdDocumentoReferencia { get; set; }

        public string DocumentoReferencia { get; set; }

        public int? IdConceptoSunat { get; set; }

        public int? IdTipoDocumentoReferencia { get; set; }

        public int? IdAlmacen { get; set; }

        public int? IdOrdenCompra { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionDetalle> CotizacionDetalle { get; set; }

        public virtual Local Local { get; set; }

        public virtual Moneda Moneda { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual TipoDocumentoPago TipoDocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoPagoDetalle> DocumentoPagoDetalle { get; set; }
    }
}
