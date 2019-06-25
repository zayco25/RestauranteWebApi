using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.ViewModels
{
 public   class MesaViewModel
    {



        public int IdMesa { get; set; }

        public string Descripcion { get; set; }

        public  int Ocupado { get; set; }

        public int IdUsuario  { get; set; }

        public string Previo { get; set; }



    }
}
