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
    public class RegistroPedidoService : IRegostroPedidoService
    {



        private UnitOfWork _UnitOfWork;

   
        public RegistroPedidoService(UnitOfWork UnitOfWork)
        {



            _UnitOfWork = UnitOfWork;

        }




        public int RegistroPedido(RegistroPedido Obj, Comanda ObjComanda, DetalleComanda ObjComandaDetalle)
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

                    Contex.Commit();
                }
                catch (Exception)
                {




                    Contex.Rollback();


                    throw;
                }

            }








            return 1;




        }



    }
}
