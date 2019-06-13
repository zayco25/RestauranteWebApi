using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Domain.Interfaces;
using SycData.Restaurante.Infra.Persistence.Context;

namespace SycData.Restaurante.Infra.Persistence.Repository
{
    public class ProductoRepository : IProducto
    {


        RestauranteModel _Context;


        public ProductoRepository(RestauranteModel Context)
        {

            _Context = Context;
        }

 

        public async Task<IEnumerable<Producto>> GetProductos()
        {

            var result = await _Context.Producto.ToListAsync();

            return result;


        }




    }
}
