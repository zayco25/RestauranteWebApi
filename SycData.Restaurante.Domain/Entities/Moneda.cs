namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Moneda")]
    public partial class Moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moneda()
        {
            Cotizacion = new HashSet<Cotizacion>();
            DocumentoPago = new HashSet<DocumentoPago>();
            EmpresaCuenta = new HashSet<EmpresaCuenta>();
            OrdenCompra = new HashSet<OrdenCompra>();
            Producto = new HashSet<Producto>();
        }

        [Key]
        public int IdMoneda { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreMoneda { get; set; }

        [Required]
        [StringLength(20)]
        public string Simbolo { get; set; }

        public int Estado { get; set; }

        [StringLength(10)]
        public string CodigoSunat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoPago> DocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaCuenta> EmpresaCuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompra> OrdenCompra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
