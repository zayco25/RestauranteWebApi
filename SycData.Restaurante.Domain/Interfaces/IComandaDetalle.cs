using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Interfaces
{
   public interface IComandaDetalle
    {


        void RegistrarDetalleComanda(int IdComanda,List<DetalleComanda> obj);
    }
}
