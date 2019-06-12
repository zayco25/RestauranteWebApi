namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormaPago")]
    public partial class FormaPago
    {
        [Key]
        public int IdFormaPago { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(40)]
        public string Abreviatura { get; set; }

        public int Estado { get; set; }
    }
}
