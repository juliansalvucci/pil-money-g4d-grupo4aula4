using Monar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Monar.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DestinoController : ApiController
    {
        // GET: api/Destino
        public IEnumerable<Destino> Get()
        {
            GestorDestino gDestino = new GestorDestino();
            return gDestino.ListarDestinos();
        }

        // GET: api/Destino/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Destino
        public HttpResponseMessage Post([FromBody] Destino value)
        {
            if (ModelState.IsValid)
            {
                GestorDestino gDestino = new GestorDestino();
                gDestino.RegistrarDestino(value);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }


        // PUT: api/Destino/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Destino/5
        public void Delete(int id)
        {
            GestorDestino gDestino = new GestorDestino();
            gDestino.EliminarDestino(id);
        }
    }
}
