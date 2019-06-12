namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SerieDocumentoPago")]
    public partial class SerieDocumentoPago
    {
        [Key]
        public int IdSeriePago { get; set; }

        public int IdTipoDocumentoPago { get; set; }

        [StringLength(15)]
        public string Numero { get; set; }

        [StringLength(15)]
        public string Serie { get; set; }

        public bool Manual { get; set; }

        public int Estado { get; set; }

        public bool Imprime { get; set; }

        [StringLength(50)]
        public string RutaImpresion { get; set; }

        public int IdLocal { get; set; }

        public virtual Local Local { get; set; }

        public virtual TipoDocumentoPago TipoDocumentoPago { get; set; }
    }
}
