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

        public void RegistrarDetalleComanda(DetalleComanda obj)
        {
            try
            {

                _Context.DetalleComanda.Add(obj);

            }
            catch (Exception)
            {

            }
        }
    }
}
