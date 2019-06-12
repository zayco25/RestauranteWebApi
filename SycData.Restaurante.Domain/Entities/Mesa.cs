using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Entities
{
    public class Mesa
    {

        public int IdMesa { get; set; }

        public string Descripcion { get; set; }

        public int Estado { get; set; }

        public int Ocupado { get; set; }

        public int IdNivel { get; set; }

        public Nivel Nivel { get; set; }

    }
}
