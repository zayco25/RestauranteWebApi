using SycData.Restaurante.Domain.Interfaces;
using SycData.Restaurante.Infra.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.ViewModels;
using System.Data.Entity;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class OperacionRepository : IOperacion
    {


        RestauranteModel _Context;


        public OperacionRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

        public async Task<OperacionViewModel> GetOpenBox()
        {



            var Result = await _Context.Operacion.Where(x => x.Estado == false).Take(1).OrderByDescending(x => x.IdOperacion).Select(x => new OperacionViewModel { IdOperacion = x.IdOperacion, Fecha = x.FechaApertura }).FirstOrDefaultAsync();



            return Result;

        }

        public async Task<TotalesViewModel> GetTotales(int IdOperacion)
        {

            var Result = await _Context.RegistroPedido.Where(x => x.IdOperacion == IdOperacion && x.Estado == 2).SumAsync(x => (decimal?)x.Total);

            var Descuento = await _Context.RegistroPedido.Where(x => x.IdOperacion == IdOperacion && x.Estado == 2).SumAsync(x => ((x.Descuento == null || x.Descuento == 0 ? 0 : x.Descuento) + (x.PDescuento == null || x.PDescuento == 0 ? 0 : ((x.PDescuento * x.Total) / 100))));

            TotalesViewModel Respuesta = new TotalesViewModel();

            Respuesta.Total = (Result == null ? 0 : Result);
            Respuesta.Descuento = (Descuento == null ? 0 : Descuento);



            return Respuesta;
        }
    }
}
