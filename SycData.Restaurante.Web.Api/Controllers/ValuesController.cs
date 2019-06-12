using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SycData.Restaurante.Web.Api.Controllers
{

    public   class ViewModel
    {

        public string Nombre { get; set; }

        public string Documento { get; set; }
    }





    public class ValuesController : ApiController
    {
        // GET api/values



        [HttpGet]
        [ResponseType(typeof(ViewModel))]
        [Route("api/Consultar")]
        public async Task<IHttpActionResult> GetViewModel()
        {
            ViewModel objk = new ViewModel();
            return Ok(objk);  // Returns an OkNegotiatedContentResult
        }



        //[HttpGet]
        //[ResponseType(typeof(string))]
        //[Route("api/Consultar")]

        //public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        //{
        //    string jsonString = "{\"id\":1,\"name\":\"a small object\" }";
        //    var content = new StringContent(jsonString);
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = content };
        //    return Task.FromResult(response);
        //}


        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
