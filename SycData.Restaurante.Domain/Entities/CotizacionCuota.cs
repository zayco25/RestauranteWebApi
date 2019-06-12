namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CotizacionCuota")]
    public partial class CotizacionCuota
    {
        [Key]
        public int IdCotizacionCuota { get; set; }

        public int Numero { get; set; }

        public double Porcentaje { get; set; }

        public double Monto { get; set; }

        public bool Estado { get; set; }

        public int IdOperacion { get; set; }

        public string Descripcion { get; set; }

        public double Saldo { get; set; }

        public DateTime? Fecha { get; set; }

        public int IdMoneda { get; set; }

        public int IdCotizacion { get; set; }

        public DateTime? FechaRegisto { get; set; }

        public double MontoTC { get; set; }

        public virtual Cotizacion Cotizacion { get; set; }
    }
}
