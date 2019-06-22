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
using SycData.Restaurante.Domain.ViewModels;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class MesaRepository : IMesa
    {

        RestauranteModel _Context;


        public MesaRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

        public async Task<IEnumerable<MesaViewModel>> GetMesa(int? IdNivel = 0,int? IdOperacion=0)
        {

            var Result = await this._Context.Mesa.Where(x => (IdNivel == 0 || x.IdNivel == IdNivel ))

                .Select(x => new MesaViewModel {

                    IdMesa = x.IdMesa,
                    Descripcion = x.Descripcion,
                    Ocupado = x.Ocupado,
                    IdUsuario = ( ( (from R in _Context.RegistroPedido where R.IdOperacion == IdOperacion && R.IdMesa==x.IdMesa && R.Estado == 1 select new { IdUsuario = (int?) R.IdUsuario }).Take(1).FirstOrDefault().IdUsuario) ?? 0) ,
                    Previo = (((from R in _Context.RegistroPedido where R.IdOperacion == IdOperacion && R.IdMesa == x.IdMesa && R.Estado == 1 select new { Previo =  R.Previo }).Take(1).FirstOrDefault().Previo) ?? ""),
                    IdRegistro = (((from R in _Context.RegistroPedido where R.IdOperacion == IdOperacion && R.IdMesa == x.IdMesa && R.Estado == 1 select new { IdRegistro = (int?)R.IdRegistroPedido }).Take(1).FirstOrDefault().IdRegistro) ?? 0),


                } ) 
                .ToListAsync();

            return Result;
        }

        public bool ValidarMesa(int IdMesa)
        {


            var Resultado = _Context.Mesa.Where(X => X.IdMesa == IdMesa).FirstOrDefault().Ocupado;

            if (Resultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
