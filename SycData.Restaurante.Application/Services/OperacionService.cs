using SycData.Restaurante.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.ViewModels;
using SycData.Restaurante.Infra.Persistence.Repository;

namespace SycData.Restaurante.Application.Services
{
    public class OperacionService : IOperacionService

    {


        private UnitOfWork _UnitOfWork;


        public OperacionService(UnitOfWork UnitOfWork)
        {



            _UnitOfWork = UnitOfWork;

        }
        public async Task<OperacionViewModel> GetOpenBox()
        {

            return await _UnitOfWork.Operacion.GetOpenBox();
        }

        public  async Task<TotalesViewModel> GetTotales(int IdOperacion)
        {

            return await _UnitOfWork.Operacion.GetTotales(IdOperacion);
        }
    }
}
