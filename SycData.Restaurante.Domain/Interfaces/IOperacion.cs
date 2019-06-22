using SycData.Restaurante.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Interfaces
{
  public  interface IOperacion
    {




        Task<OperacionViewModel> GetOpenBox();

    }
}
