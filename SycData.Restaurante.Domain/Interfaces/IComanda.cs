using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Interfaces
{
 public   interface IComanda
    {



        int RegistrarComanda(Comanda Obj);

        int RegistrarComandaMesa(RegistroPedido Obj, Comanda ObjComanda, List<DetalleComanda> ObjDetalle);


    }
}
