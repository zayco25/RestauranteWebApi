using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Entities
{
 public    class DetalleComanda
    {


        public int IdDetalleComanda { get; set; }

        public int IdComanda { get; set; }

        public Comanda Comanda { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Total { get; set; }

        public string Observacion { get; set; }

        public int Combo { get; set; }

        public int Estado { get; set; }

        public int IdProductoCombo { get; set; }

        public int CantidadCombo { get; set; }

        public int? IdConcepto { get; set; }


    }
}
