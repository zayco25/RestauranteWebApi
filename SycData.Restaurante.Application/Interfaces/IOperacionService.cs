using SycData.Restaurante.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Application.Interfaces
{
  public  interface IOperacionService
    {
        Task<OperacionViewModel> GetOpenBox();

        Task<TotalesViewModel> GetTotales(int IdOperacion);
    }
}
