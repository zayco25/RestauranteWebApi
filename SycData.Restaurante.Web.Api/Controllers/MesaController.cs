using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Web.Http;
using SycData.Restaurante.Application.Services;
using System.Threading.Tasks;

namespace SycData.Restaurante.Web.Api.Controllers
{
    public class MesaController : ApiController
    {


        private readonly MesaService _MesaService;


        public MesaController(MesaService MesaService)


        {

            _MesaService = MesaService;
        }



        [Authorize]
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Mesa/GetMesa")]
        public async Task<IHttpActionResult> GetMesa(int IdNivel = 0)
        {
            var Result = await _MesaService.GetMesa(IdNivel);


            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }



    }
}
