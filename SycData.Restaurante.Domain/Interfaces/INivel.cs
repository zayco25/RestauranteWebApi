using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Interfaces
{
  public  interface INivel
    {






        Task<IEnumerable<Nivel>> GetNivel();




    }
}
