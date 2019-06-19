using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Application.Interfaces
{
    public interface IComandaService
    {


        int RegistrarComanda(Comanda Obj);
        void RegistrarDetalleComanda(int IdComanda , List<DetalleComanda> Obj);
    }
}
