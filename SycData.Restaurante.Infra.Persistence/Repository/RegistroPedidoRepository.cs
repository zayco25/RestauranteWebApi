using SycData.Restaurante.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Context;
using SycData.Restaurante.Domain.ViewModels;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class RegistroPedidoRepository : IRegistroPedido

    {

        RestauranteModel _Context;


        public RegistroPedidoRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

        public void ActualizarPedido(RegistroPedido Obj)
        {
          


            RegistroPedido ObjP = new RegistroPedido();


            ObjP = _Context.RegistroPedido.AsNoTracking().Where(x => x.IdRegistroPedido == Obj.IdRegistroPedido).FirstOrDefault();

            //ObjP.IdRegistroPedido = Obj.IdRegistroPedido;
            ObjP.Previo = "";
            ObjP.Total = ObjP.Total + Obj.Total;

            _Context.Configuration.ValidateOnSaveEnabled = false;
            _Context.RegistroPedido.Attach(ObjP);


        }

        public async Task<IEnumerable<DetalleComandaViewModel>> GetPedidosDetalle(int IdRegistro)
        {

            var Lista = await (from c in _Context.Comanda
                               join cd in _Context.DetalleComanda on c.IdComanda  equals cd.IdComanda

                               join P in _Context.Producto on cd.IdProducto  equals P.IdProducto 



                               where c.IdMesa==IdRegistro

                               select new  
                               {
                                   
                                   IdDetalleComanda = cd.IdDetalleComanda ,
                                   IdComanda = cd.IdComanda,
                                   IdProducto = cd.IdProducto ,
                                   Cantidad  = cd.Cantidad ,
                                   Precio = cd.Precio ,
                                   Total = cd.Total,
                                   Hora = c.Hora,
                                   Producto =P.Descripcion
                                    

                               }
                         ).Select(cd => new DetalleComandaViewModel {
                            
                             IdDetalleComanda = cd.IdDetalleComanda,
                             IdComanda = cd.IdComanda,
                             IdProducto = cd.IdProducto,
                             Cantidad = cd.Cantidad,
                             Precio = cd.Precio,
                             Total = cd.Total,
                             Hora =  cd.Hora,
                             Producto=cd.Producto


                         }).ToListAsync();


            return Lista;
        }

        public async Task<IEnumerable<RegistroViewModel>> GetRegistroPedidos(int IdOperacion, int IdUsuario)
        {



            var Lista =  await (from Re in _Context.RegistroPedido
                         join M in _Context.Mesa on Re.IdMesa equals M.IdMesa


                         where Re.IdOperacion == IdOperacion && Re.IdUsuario == IdUsuario

                         select new RegistroViewModel
                         {

                            IdRegistro =Re.IdRegistroPedido ,
                            IdMesa =Re.IdMesa ,
                            Mesa = M.Descripcion ,
                            Previo = Re.Previo

                         }
                         ).ToListAsync();


            return Lista;

        }

        public int RegistrarPedido(RegistroPedido Obj)
        {
          int Valor = 0;

            try
            {
                int CuentaNumero = 0;

                var Cuenta = _Context.RegistroPedido.AsNoTracking().Where(x => x.IdOperacion == Obj.IdOperacion).Max(x=>(int?) x.Cuenta);


                if (Cuenta == null)
                {

                    CuentaNumero = 1;
                }else
                {

                    CuentaNumero =  Convert.ToInt32( Cuenta )+ 1;
                }



                Obj.Cuenta = CuentaNumero;



                _Context.RegistroPedido.Add(Obj);
                Valor = Obj.IdRegistroPedido;
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message.ToString());
            }

            return Valor;
        }
    }
}
