namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int IdEmpleado { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        public int TipoDocumento { get; set; }

        [StringLength(20)]
        public string Documento { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        public DateTime? FechaCumpleaños { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        public int Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
