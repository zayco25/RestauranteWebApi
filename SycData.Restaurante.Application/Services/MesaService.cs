using SycData.Restaurante.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Repository;

namespace SycData.Restaurante.Application.Services
{
    public class MesaService : IMesaService
    {
        private MesaRepository _mesaRepository;


        public MesaService(MesaRepository mesaRepository)
        {

            _mesaRepository = mesaRepository;

        }
        public async Task<IEnumerable<Mesa>> GetMesa(int? IdNivel = 0)
        {


            var Result = await _mesaRepository.GetMesa((IdNivel));


            return Result;
        }
    }
}
