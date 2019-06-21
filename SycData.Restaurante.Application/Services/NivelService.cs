using SycData.Restaurante.Application.Interfaces;
using SycData.Restaurante.Infra.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;

namespace SycData.Restaurante.Application.Services
{
   public class NivelService:INivelService
    {

        private UnitOfWork _UnitOfWork;


        public NivelService(UnitOfWork UnitOfWork)
        {



            _UnitOfWork = UnitOfWork;

        }

        public async Task<IEnumerable<Nivel>> GetNivel()
        {
            return await _UnitOfWork.Nivel.GetNivel();
        }
    }
}
