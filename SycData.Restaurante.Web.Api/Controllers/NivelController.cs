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
    public class NivelController : ApiController
    {

        private readonly NivelService _NivelService;


        public NivelController(NivelService NivelService)
        {
            _NivelService = NivelService;
        }


        [Authorize]
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Nivel/GetNiveles")]
        public async Task<IHttpActionResult> GetNiveles()
        {
            var Result = await _NivelService.GetNivel();


            return Ok(Result);  // Returns an OkNegotiatedContentResult
        }



    }
}
