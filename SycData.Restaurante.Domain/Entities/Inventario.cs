namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventario")]
    public partial class Inventario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventario()
        {
            Inventariodetalle = new HashSet<Inventariodetalle>();
        }

        [Key]
        public int IdInventario { get; set; }

        public DateTime FechaEmision { get; set; }

        public int IdUsuario { get; set; }

        public int IdAlmacen { get; set; }

        public string Estado { get; set; }

        public string Observacion { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Almacen Almacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventariodetalle> Inventariodetalle { get; set; }
    }
}
