namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoMovimientoAlmacen")]
    public partial class TipoMovimientoAlmacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoMovimientoAlmacen()
        {
            Movimiento = new HashSet<Movimiento>();
        }

        [Key]
        public int IdTipoMovimiento { get; set; }

        [Required]
        public string NombreTipoMovimiento { get; set; }

        public int Estado { get; set; }

        [Required]
        public string Tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimiento> Movimiento { get; set; }
    }
}
