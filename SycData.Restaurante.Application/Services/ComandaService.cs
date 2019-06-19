using SycData.Restaurante.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Repository;

namespace SycData.Restaurante.Application.Services
{
    public class ComandaService : IComandaService
    {


        private UnitOfWork _UnitOfWork;


        public ComandaService(UnitOfWork UnitOfWork)
        {



            _UnitOfWork = UnitOfWork;

        }

        public int RegistrarComanda(Comanda Obj)
        {
            return _UnitOfWork.Comanda.RegistrarComanda(Obj);
        }

        public void RegistrarDetalleComanda(int IdComanda ,List<DetalleComanda> Obj)
        {
            _UnitOfWork.DetalleComanda.RegistrarDetalleComanda(IdComanda,Obj);
        }
    }
}
