using SycData.Restaurante.Application.Interfaces;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Repository;
using SycData.Restaurante.Domain.ViewModels;

namespace SycData.Restaurante.Application.Services
{
    public class RegistroPedidoService : IRegostroPedidoService
    {



        private UnitOfWork _UnitOfWork;

   
        public RegistroPedidoService(UnitOfWork UnitOfWork)
        {



            _UnitOfWork = UnitOfWork;

        }

        public async Task<IEnumerable<DetalleComandaViewModel>> GetPedidosDetalle(int IdRegistro)
        {

            return await _UnitOfWork.RegistroPedido.GetPedidosDetalle(IdRegistro);
        }

        public async Task<IEnumerable<RegistroViewModel>> GetRegistroPedidos(int IdOperacion, int IdUsuario)
        {


            return await _UnitOfWork.RegistroPedido.GetRegistroPedidos(IdOperacion, IdUsuario);
        }

        public void ImprimirPrevio(int IdRegistroPedido)
        {
            _UnitOfWork.RegistroPedido.ImprimirPrevio(IdRegistroPedido);
            _UnitOfWork.CommintSaveChanges();
        }

        public int RegistroPedido(RegistroPedido Obj, Comanda ObjComanda, List<DetalleComanda> ObjComandaDetalle)
        {

           int IdComanda = 0;

           int IdMesa = 0;
           



            using (var Contex = _UnitOfWork._context.Database.BeginTransaction())
            {

                try
                {


                    if (Obj.IdRegistroPedido == 0)
                    {

                        IdMesa= _UnitOfWork.RegistroPedido.RegistrarPedido(Obj);

                        Obj.IdRegistroPedido = IdMesa;

                    }
                    else
                    {
                        _UnitOfWork.RegistroPedido.ActualizarPedido(Obj);
                                               

                    }
                    

                    _UnitOfWork.CommintSaveChanges();
                    _UnitOfWork.Comanda.RegistrarComandaMesa(Obj, ObjComanda, ObjComandaDetalle);
                    _UnitOfWork.CommintSaveChanges();

                    _UnitOfWork.DetalleComanda.RegistrarDetalleComanda(ObjComanda.IdComanda, ObjComandaDetalle);
                    _UnitOfWork.CommintSaveChanges();

                    Contex.Commit();

                    IdComanda = ObjComanda.IdComanda;
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message.ToString());



                    Contex.Rollback();


                    throw;
                }

            }








            return 1;




        }


   
    }
}
