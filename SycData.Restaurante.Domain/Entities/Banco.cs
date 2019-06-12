namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banco")]
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            EmpresaCuenta = new HashSet<EmpresaCuenta>();
        }

        [Key]
        public int IdBanco { get; set; }

        [StringLength(50)]
        public string NombreBanco { get; set; }

        public int Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaCuenta> EmpresaCuenta { get; set; }
    }
}
