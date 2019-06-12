using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Entities
{
   public class RegistroPedido
    {



        public int IdRegistroPedido { get; set; }

        public int IdMesa { get; set; }


        public Mesa Mesa { get; set; }

        public decimal? PDescuento { get; set; }
        public decimal? Descuento { get; set; }

        public int? IdPersonal { get; set; }

        public decimal   Total { get; set; }
        public int Estado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int IdUsuario { get; set; }

        public string Previo { get; set; }

        public int Cuenta { get; set; }

        public int NPersonas { get; set; }

        public string Cliente { get; set; }

        public int IdOperacion { get; set; }

        public int? IdMesaAnterior { get; set; }

        public DateTime FechaCaja { get; set; }


        public string Tipo { get; set; }


        public int IdTurno { get; set; }





    }
}
