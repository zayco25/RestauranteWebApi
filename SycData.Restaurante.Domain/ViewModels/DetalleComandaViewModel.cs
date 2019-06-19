using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.ViewModels
{
public    class DetalleComandaViewModel
    {

        public int IdDetalleComanda { get; set; }

        public int IdComanda { get; set; }

        public int IdProducto { get; set; }

        public string Producto { get; set; }


        public decimal Precio { get; set; }
        public decimal Total { get; set; }


        public DateTime Hora { get; set; }

        public int Cantidad { get; set; }
    }
}
