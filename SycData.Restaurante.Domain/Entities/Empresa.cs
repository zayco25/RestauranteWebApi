namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            EmpresaCuenta = new HashSet<EmpresaCuenta>();
            Local = new HashSet<Local>();
        }

        [Key]
        public int IdEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(50)]
        public string RazonComercial { get; set; }

        [Required]
        [StringLength(15)]
        public string Ruc { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        public int Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string RutaImagen { get; set; }

        public string Web { get; set; }

        public int Igv { get; set; }

        [StringLength(250)]
        public string Correo { get; set; }

        public string Departamento { get; set; }

        public string Provincia { get; set; }

        public string Distrito { get; set; }

        public string CodigoPais { get; set; }

        public string Usuario { get; set; }

        public string ClaveSol { get; set; }

        public string Ubigeo { get; set; }

        public int TipoProceso { get; set; }

        public bool LiquidacionFormato { get; set; }

        public bool EnvioSunatOnline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaCuenta> EmpresaCuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Local> Local { get; set; }
    }
}
