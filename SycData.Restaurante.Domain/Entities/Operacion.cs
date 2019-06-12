namespace SycData.Restaurante.Infra.Persistence.Context
{
    using Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operacion")]
    public partial class Operacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operacion()
        {
            OperacionDetalle = new HashSet<OperacionDetalle>();
        }

        [Key]
        public int IdOperacion { get; set; }

        public int IdTurno { get; set; }

        public DateTime FechaApertura { get; set; }

        public double? SaldoInicialS { get; set; }

        public double? SaldoInicialD { get; set; }

        public bool Estado { get; set; }

        public int IdLocal { get; set; }

        public int IdUsuario { get; set; }

        public double? SaldoFinal { get; set; }

        public double? SaldoFinalD { get; set; }

        public double TipoCambioC { get; set; }

        public double TipoCambioV { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public double ValorActivo { get; set; }

        public double ValorMercaderia { get; set; }

        public virtual Local Local { get; set; }

        public virtual Turno Turno { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperacionDetalle> OperacionDetalle { get; set; }



        public virtual ICollection<Comanda> Comandas { get; set; }



    }
}
