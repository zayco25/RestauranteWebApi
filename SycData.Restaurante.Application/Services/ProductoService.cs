using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SycData.Restaurante.Application.Interfaces;
using SycData.Restaurante.Infra.Persistence.Context;
using SycData.Restaurante.Infra.Persistence.Repository;

namespace SycData.Restaurante.Application.Services
{
    public class ProductoService : IProductoService

    {


        private readonly ProductoRepository _ProductoRepository;

        public ProductoService(ProductoRepository ProductoRepository)
        {
            _ProductoRepository = ProductoRepository;
        }

        public async Task<IEnumerable<Producto>> GetProductos()
        {

            var result = await _ProductoRepository.GetProductos();
            return result;
        }
    }
}
