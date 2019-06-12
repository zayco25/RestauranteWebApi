using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Infra.Persistence.Context;

namespace SycData.Restaurante.Domain.Entities
{
 public   class Comanda
    {


        public int IdComanda { get; set; }

        public int IdMozo { get; set; }

        public int IdMesa { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int IdOperacion { get; set; }

        public decimal Total { get; set; }

        public int IdUsuario { get; set; }

        public DateTime Hora { get; set; }


        public string Estado { get; set; }

        public int NComanda { get; set; }

        public Operacion Operacion { get; set; }

        public virtual ICollection<DetalleComanda> DetalleComanda { get; set; }
    }
}
