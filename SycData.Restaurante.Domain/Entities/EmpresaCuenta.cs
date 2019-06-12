namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresaCuenta")]
    public partial class EmpresaCuenta
    {
        [Key]
        public int IdEmpresaCuenta { get; set; }

        public int IdEmpresa { get; set; }

        public int IdBanco { get; set; }

        public int IdMoneda { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Moneda Moneda { get; set; }
    }
}
