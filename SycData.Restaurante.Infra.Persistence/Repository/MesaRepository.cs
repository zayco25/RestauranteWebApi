using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Domain.Interfaces;
using SycData.Restaurante.Infra.Persistence.Context;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class MesaRepository : IMesa
    {

        RestauranteModel _Context;


        public MesaRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

        public async Task<IEnumerable<Mesa>> GetMesa(int? IdNivel = 0)
        {

            var Result = await this._Context.Mesa.Where(x => (IdNivel == 0 || x.IdNivel == IdNivel)).ToListAsync();

            return Result;
        }
    }
}
