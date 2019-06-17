using SycData.Restaurante.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Context;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class ComandaRepository : IComanda
    {






        RestauranteModel _Context;


        public ComandaRepository(RestauranteModel Context)
        {

            _Context = Context;
        }



        public int RegistrarComanda(Comanda Obj)
        {


          int Valor = 0;

            try
            {

                _Context.Comanda.Add(Obj);
                Valor = Obj.IdComanda;
            }
            catch (Exception)
            {

            }

            return Valor;
         
    }

        public int RegistrarComandaMesa(RegistroPedido Obj, Comanda ObjComanda, List<DetalleComanda> ObjDetalle)
        {
            throw new NotImplementedException();
        }
    }
}
