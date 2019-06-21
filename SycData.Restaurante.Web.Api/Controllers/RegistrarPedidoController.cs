using SycData.Restaurante.Application.Services;
using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

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





        [Authorize]
        [HttpPost]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/RegistrarPedido/ImprimirPrevio")]
        public IHttpActionResult ImprimirPrevio([FromBody] Parameters param)
        {
           _RegistroPedidoService.ImprimirPrevio(param.IdRegistroPedido);

            return Ok();  // Returns an OkNegotiatedContentResult
        }






        [Authorize]
        [HttpGet]
        [ResponseType(typeof(RegistroViewModel))]
        [Route("api/RegistrarPedido/GetPedidos")]
        public async Task<IHttpActionResult> GePedidos(int IdOperacion , int IdUsuario)
        {
            var Result = await _RegistroPedidoService.GetRegistroPedidos(IdOperacion,IdUsuario);

            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }





        [Authorize]
        [HttpGet]
        [ResponseType(typeof(DetalleComandaViewModel))]
        [Route("api/RegistrarPedido/GetDetallePedidos")]
        public async Task<IHttpActionResult> GetPedidos(int IdRegistro)
        {
            var Result = await _RegistroPedidoService.GetPedidosDetalle(IdRegistro);

            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }




    }


    public class RegistroModelView
    {


        public RegistroPedido Pedido { get; set; }
        public Comanda      Cabecera { get; set; }

        public List<DetalleComanda> Detalle { get; set; }



    }

    public class Parameters
    {

        public int IdRegistroPedido  { get; set; }

    }

}
