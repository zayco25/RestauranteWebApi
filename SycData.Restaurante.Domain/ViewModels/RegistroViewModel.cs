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

    }
}
