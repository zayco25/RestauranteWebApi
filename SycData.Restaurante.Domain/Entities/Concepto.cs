namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Concepto")]
    public partial class Concepto
    {
        [Key]
        public int IdConcepto { get; set; }

        [Required]
        public string NombreConceptop { get; set; }

        public int Estado { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
    }
}
