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
    public class OperacionController : ApiController
    {



        private readonly OperacionService _OperacionService;


        public OperacionController(OperacionService OperacionService)


        {

            _OperacionService = OperacionService;
        }



        [Authorize]
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Operacion/GetOpenBox")]
        public async Task<IHttpActionResult> GetOpenBox()
        {
            var Result = await _OperacionService.GetOpenBox();
            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }



        [Authorize]
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Operacion/Totales")]
        public async Task<IHttpActionResult> GetTotales(int IdOperacion)
        {
            var Result = await _OperacionService.GetTotales(IdOperacion);

            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }

    }
}
