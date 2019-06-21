using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Application.Interfaces
{

public    interface IRegostroPedidoService
    {


        Task<IEnumerable<RegistroViewModel>> GetRegistroPedidos(int IdOperacion, int IdUsuario);
        int RegistroPedido(RegistroPedido Obj ,Comanda ObjComanda , List<DetalleComanda> ObjComandaDetalle);
        Task<IEnumerable<DetalleComandaViewModel>> GetPedidosDetalle(int IdRegistro);

        void ImprimirPrevio(int IdRegistroPedido);
    }
}
