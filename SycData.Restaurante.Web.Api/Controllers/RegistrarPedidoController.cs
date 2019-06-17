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
        public IHttpActionResult RegistrarPedido(RegistroPedido  Pedido , Comanda  Cabecera ,DetalleComanda Detalle)
        {
            var Result = _RegistroPedidoService.RegistroPedido(Pedido, Cabecera, Detalle);


            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }




    }
}
