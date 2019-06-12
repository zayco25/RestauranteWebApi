namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoMovimiento")]
    public partial class TipoMovimiento
    {
        [Key]
        public int IdTipoMovimiento { get; set; }

        [Required]
        public string NombreTipoMovimiento { get; set; }

        public int Estado { get; set; }

        public int Tipo { get; set; }
    }
}
