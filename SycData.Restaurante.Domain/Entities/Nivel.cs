using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Entities
{
  public  class Nivel
    {

        public int IdNivel { get; set; }

        public string Descripcion { get; set; }

        public  int Estado { get; set; }


        public virtual ICollection<Mesa> Mesas { get; set; }


    }
}
