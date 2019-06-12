namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movimiento")]
    public partial class Movimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movimiento()
        {
            MovimientoDetalle = new HashSet<MovimientoDetalle>();
        }

        [Key]
        public int IdMovimiento { get; set; }

        public int Idusuario { get; set; }

        public DateTime FechaEmision { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int IdAlmacen { get; set; }

        public string Tipo { get; set; }

        public int Recibido { get; set; }

        public string Observacion { get; set; }

        public string Documento { get; set; }

        public string Estado { get; set; }

        public int? IdProveedor { get; set; }

        public int IdTipoMovimiento { get; set; }

        public int? IdAlmacenDestino { get; set; }

        public int? IdMovimientoTrans { get; set; }

        public int? IdOrdenCompra { get; set; }

        public int? IdTipoDocumentoPago { get; set; }

        public string Serie { get; set; }

        public string Numero { get; set; }

        public string Guia { get; set; }

        public int? IdDocumentoPago { get; set; }

        public int? IdLocal { get; set; }

        public virtual Almacen Almacen { get; set; }

        public virtual TipoDocumentoPago TipoDocumentoPago { get; set; }

        public virtual TipoMovimientoAlmacen TipoMovimientoAlmacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoDetalle> MovimientoDetalle { get; set; }
    }
}
