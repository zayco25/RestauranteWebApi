namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Cotizacion = new HashSet<Cotizacion>();
            DocumentoPago = new HashSet<DocumentoPago>();
            OrdenEnvio = new HashSet<OrdenEnvio>();
        }

        [Key]
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string ApellidosPaterno { get; set; }

        public string ApellidosMaterno { get; set; }

        public int TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Telefono { get; set; }

        public int Estado { get; set; }

        public string Ubigeo { get; set; }

        [StringLength(250)]
        public string RazonComercial { get; set; }

        [StringLength(250)]
        public string RazonSocial { get; set; }

        public string Contacto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoPago> DocumentoPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenEnvio> OrdenEnvio { get; set; }
    }
}
