using SycData.Restaurante.Application.Services;
using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SycData.Restaurante.Web.Api.Controllers
{
    public class RegistrarPedidoController : ApiController
    {






        private readonly RegistroPedidoService _RegistroPedidoService;


        public RegistrarPedidoController(RegistroPedidoService RegistroPedidoService)


        {

            _RegistroPedidoService = RegistroPedidoService;
        }



        [Authorize]
        [HttpPost]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/RegistrarPedido/Registrar")]
        public IHttpActionResult RegistrarPedido ( [FromBody] RegistroModelView parameters)
        {
            var Result = _RegistroPedidoService.RegistroPedido(parameters.Pedido, parameters.Cabecera, parameters.Detalle);


            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }




    }


    public class RegistroModelView
    {


        public RegistroPedido Pedido { get; set; }
        public Comanda      Cabecera { get; set; }

        public List<DetalleComanda> Detalle { get; set; }



    }

}
