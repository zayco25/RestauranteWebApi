namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoDocumentoPago")]
    public partial class TipoDocumentoPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDocumentoPago()
        {
            Cotizacion = new HashSet<Cotizacion>();
            DocumentoPago = new HashSet<DocumentoPago>();
            Movimiento = new HashSet<Movimiento>();
            OrdenCompra = new HashSet<OrdenCompra>();
            OrdenEnvio = new HashSet<OrdenEnvio>();
            SerieDocumentoPago = new HashSet<SerieDocumentoPago>();
        }

        [Key]
        public int IdTipoDocumentoPago { get; set; }

        [StringLength(50)]
        public string NombreDocumento { get; set; }

        public int Estado { get; set; }

        public string CodigoSunat { get; set; }

        public string Tipo { get; set; }

        public bool TipoFormato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoPago> DocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimiento> Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompra> OrdenCompra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenEnvio> OrdenEnvio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SerieDocumentoPago> SerieDocumentoPago { get; set; }
    }
}
