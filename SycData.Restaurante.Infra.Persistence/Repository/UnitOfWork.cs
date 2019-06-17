using SycData.Restaurante.Domain.Core.SeedWork;
using SycData.Restaurante.Domain.Interfaces;
using SycData.Restaurante.Infra.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public RestauranteModel _context;



        public IRegistroPedido RegistroPedido { get; private set; }

        public IComanda Comanda { get; private set; }
        public IComandaDetalle DetalleComanda { get; private set; }


        public UnitOfWork(RestauranteModel Context)
        {

            _context = Context;


            RegistroPedido = new RegistroPedidoRepository(Context);
            Comanda = new ComandaRepository(Context);

            DetalleComanda = new DetalleComandaRepository(Context);

        }


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();

            }
        }

        public async Task<int> SaveChangesAsync()
        {


            var result = await this._context.SaveChangesAsync();
            return 1;

        }

        public bool SaveChanges()
        {
            bool returnValue = true;
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    this._context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    returnValue = false;
                    dbContextTransaction.Rollback();
                }
            }

            return returnValue;
        }

        public bool CommintSaveChanges()
        {
            this._context.SaveChanges();

            return true;
        }
    }
}
