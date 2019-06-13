using SycData.Restaurante.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SycData.Restaurante.Web.Api.Controllers
{
    public class ProductoController : ApiController
    {



        private readonly ProductoService _ProductoService;


        public ProductoController(ProductoService ProductoService)


        {

            _ProductoService = ProductoService;
        }

        [Authorize]
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Producto/getProductos")]
        public async Task<IHttpActionResult> GetProductos()
        {
            var Result = await _ProductoService.GetProductos();
            
            
            return Ok( Result);  // Returns an OkNegotiatedContentResult
        }



    }
}
