namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperacionDetalle")]
    public partial class OperacionDetalle
    {
        [Key]
        public int IdOperacionDetalle { get; set; }

        public int IdOperacion { get; set; }

        public DateTime Fecha { get; set; }

        public int IdUsuario { get; set; }

        public int IdConcepto { get; set; }

        public decimal Total { get; set; }

        public int IdMoneda { get; set; }

        public string Observacion { get; set; }

        public string Tipo { get; set; }

        public string Estado { get; set; }

        public int? IdCotizacion { get; set; }

        public int? IdDocumentoPago { get; set; }

        public int? IdRegistro { get; set; }

        public int IdFormaPago { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? IdCotizacionCuota { get; set; }

        public string CodigoOperacion { get; set; }

        public int? IdEmpresaCuenta { get; set; }

        public int? IdPersonal { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
