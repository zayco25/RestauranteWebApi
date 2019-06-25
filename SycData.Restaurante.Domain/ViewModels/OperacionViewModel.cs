using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.ViewModels
{
   public class OperacionViewModel
    {

        public int IdOperacion { get; set; }

        public DateTime Fecha { get; set; }

        public int IdTurno { get; set; }

    }
}
