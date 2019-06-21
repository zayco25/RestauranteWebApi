using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Interfaces
{
  public  interface IRegistroPedido
    {


        int RegistrarPedido(RegistroPedido Obj);



        void ActualizarPedido(RegistroPedido Obj);

        Task<IEnumerable<RegistroViewModel>> GetRegistroPedidos(int IdOperacion, int IdUsuario);

        Task<IEnumerable<DetalleComandaViewModel>> GetPedidosDetalle(int IdRegistro);


        void ImprimirPrevio(int IdRegistroPedido);

    }
}
