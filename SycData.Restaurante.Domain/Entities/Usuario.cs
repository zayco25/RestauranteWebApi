namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Operacion = new HashSet<Operacion>();
        }

        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        public int Estado { get; set; }

        public int? IdEmpleado { get; set; }

        public int Conectado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaConexion { get; set; }

        public string Tipo { get; set; }

        public int? Sistema { get; set; }

        public string NombreEmpresa { get; set; }

        public bool Aperturar { get; set; }

        public bool Caja { get; set; }

        public bool Ventas { get; set; }

        public bool Admin { get; set; }

        public bool Almacen { get; set; }

        public int? IdLocal { get; set; }

        public bool? Cuentas { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Local Local { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
