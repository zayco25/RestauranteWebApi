using SycData.Restaurante.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Context;
using System.Data.Entity;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class NivelRepository : INivel
    {

        RestauranteModel _Context;


        public NivelRepository(RestauranteModel Context)
        {

            _Context = Context;
        }
         

        public async Task<IEnumerable<Nivel>> GetNivel()
        {
            var Result = await this._Context.Nivel.Where(x => x.Estado == 1).ToListAsync();

            return Result;
        }
    }
}
