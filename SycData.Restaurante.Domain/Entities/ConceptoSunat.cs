namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConceptoSunat")]
    public partial class ConceptoSunat
    {
        [Key]
        public int IdConceptoSunat { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(3)]
        public string CodigoSunat { get; set; }

        public bool Tipo { get; set; }
    }
}
