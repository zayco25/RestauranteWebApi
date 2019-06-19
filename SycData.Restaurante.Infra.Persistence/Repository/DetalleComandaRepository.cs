using SycData.Restaurante.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Context;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class DetalleComandaRepository : IComandaDetalle
    {


        RestauranteModel _Context;


        public DetalleComandaRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

        //public void RegistrarDetalleComanda(DetalleComanda obj)
        //{
        //    try
        //    {

        //        _Context.DetalleComanda.Add(obj);

        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        public void RegistrarDetalleComanda(int IdComanda, List<DetalleComanda> obj)
        {


            try
            {

                foreach (var item in obj)
                {



                    var Detalle = new DetalleComanda();

                    Detalle.IdDetalleComanda = item.IdDetalleComanda;
                    Detalle.IdComanda = IdComanda;
                    Detalle.IdProducto = item.IdProducto;
                    Detalle.Cantidad = item.Cantidad;
                    Detalle.Precio = item.Precio;
                    Detalle.Total = item.Total;
                    Detalle.Observacion = item.Observacion;
                    Detalle.Combo = item.Combo;
                    Detalle.Estado = item.Estado;
                    Detalle.IdProductoCombo = item.IdProductoCombo;
                    Detalle.CantidadCombo = item.CantidadCombo;
                    Detalle.IdConcepto = item.IdConcepto;



                    _Context.DetalleComanda.Add(Detalle);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
