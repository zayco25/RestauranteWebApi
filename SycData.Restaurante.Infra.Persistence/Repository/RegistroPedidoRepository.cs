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
    public class RegistroPedidoRepository : IRegistroPedido

    {

        RestauranteModel _Context;


        public RegistroPedidoRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

        public void ActualizarPedido(RegistroPedido Obj)
        {
            throw new NotImplementedException();
        }

        public int RegistrarPedido(RegistroPedido Obj)
        {
          int Valor = 0;

            try
            {

                _Context.RegistroPedido.Add(Obj);
                Valor = Obj.IdRegistroPedido;
            }
            catch (Exception)
            {
                
            }

            return Valor;
        }
    }
}
