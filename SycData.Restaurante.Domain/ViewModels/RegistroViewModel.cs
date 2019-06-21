using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.ViewModels
{
   public class RegistroViewModel
    {


        public int IdRegistro { get; set; }

        public int IdMesa { get; set; }

        public string Mesa { get; set; }

        public string Previo { get; set; }


        public decimal Total { get; set; }


        public string Usuario { get; set; }

        public int Npersonas { get; set; }


        public string Cliente { get; set; }

        public int Cuenta { get; set; }


        

        public decimal? Descuento { get; set; }

        public decimal? Pdescuento { get; set; }

    }
}
