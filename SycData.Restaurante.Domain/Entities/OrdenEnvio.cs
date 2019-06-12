namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenEnvio")]
    public partial class OrdenEnvio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenEnvio()
        {
            OrdenEnvioDetalle = new HashSet<OrdenEnvioDetalle>();
        }

        [Key]
        public int IdOrdenEnvio { get; set; }

        public int IdTipoDocumento { get; set; }

        [StringLength(30)]
        public string Serie { get; set; }

        [StringLength(30)]
        public string Numero { get; set; }

        public DateTime FechaEmision { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaEntrega { get; set; }

        public int IdCliente { get; set; }

        [StringLength(150)]
        public string DireccionPartida { get; set; }

        [StringLength(150)]
        public string DireccionLlegada { get; set; }

        public int IdAlmacen { get; set; }

        public int? IdDocumentoPago { get; set; }

        public string CodigoRespuesta { get; set; }

        public string Hashcdr { get; set; }

        public string Hashcpe { get; set; }

        public int DocumentoEnviado { get; set; }

        public string MensajeSunat { get; set; }

        public string Estado { get; set; }

        public string Motivo { get; set; }

        public string TipoTransporte { get; set; }

        public string EmpresaTransportista { get; set; }

        public string DocEmpresaTransportista { get; set; }

        public int IdLocal { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual TipoDocumentoPago TipoDocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenEnvioDetalle> OrdenEnvioDetalle { get; set; }
    }
}
