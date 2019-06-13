using SycData.Restaurante.Application.Services;
using SycData.Restaurante.Infra.Persistence.Context;
using SycData.Restaurante.Web.Api.Helpers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiSegura.Security;

namespace SycData.Restaurante.Web.Api.Controllers
{

    ///<summary>
    ///Clase principal de la aplicación.
    ///</summary>
 
    public class UsuarioController : ApiController

{


    private readonly UsuarioService _UsuarioService;



        public UsuarioController() { }
        ///<summary>
        ///Clase principal de la aplicación.
        ///</summary>
        ///<remarks>
        ///Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
        ///</remarks>

        public UsuarioController(UsuarioService UsuarioService) 
        {
            _UsuarioService = UsuarioService;
        }

        ///<summary>
        ///Clase principal de la aplicación.
        ///</summary>
        //////asdjkashdhasd
        ///<remarks>
        ///Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
        ///</remarks>
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Usuario/Login")]
        public async Task<IHttpActionResult> GetUser(string Clave)
        {
            var Result = await _UsuarioService.GetUser(Clave);
            string Tk=string.Empty;
            if (Result != null)
            {
                foreach (var item in Result)
                {
                    Tk = TokenGenerator.GenerateTokenJwt(item.NombreUsuario,"Usuario");
                }                 

            }
            return Ok(new { Result ,Tokken = Tk });  // Returns an OkNegotiatedContentResult
        }



        [Authorize]
        [HttpGet]
        //[ResponseType(typeof(ViewModel))]
        [Route("api/Usuario/Prueba")]
        public async Task<IHttpActionResult> Prueba()
        {

            var Texto = "asdasdasd";
          
            return Ok(Texto);  // Returns an OkNegotiatedContentResult
        }




    }
}
