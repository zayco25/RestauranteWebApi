namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            DocumentoPago = new HashSet<DocumentoPago>();
            OrdenCompra = new HashSet<OrdenCompra>();
        }

        [Key]
        public int IdProveedor { get; set; }

        [StringLength(250)]
        public string RazonComercial { get; set; }

        [StringLength(250)]
        public string RazonSocial { get; set; }

        public string Contacto { get; set; }

        public int TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Telefono { get; set; }

        public int Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoPago> DocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompra> OrdenCompra { get; set; }
    }
}
