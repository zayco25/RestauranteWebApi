using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Application.Interfaces
{

public    interface IRegostroPedidoService
    {


        int RegistroPedido(RegistroPedido Obj ,Comanda ObjComanda , List<DetalleComanda> ObjComandaDetalle);
    }
}
