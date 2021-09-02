using Monar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monar.Controllers
{
    public class TarjetaController : ApiController
    {
        // GET: api/Tarjeta
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tarjeta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tarjeta
        public HttpResponseMessage Post([FromBody]Tarjeta value)
        {
            if (ModelState.IsValid)
            {
                GestorTarjeta gTarjeta = new GestorTarjeta();
                gTarjeta.RegistrarTarjeta(value);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/Tarjeta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tarjeta/5
        public void Delete(int id)
        {
            GestorTarjeta gTarjeta = new GestorTarjeta();
            gTarjeta.EliminarTarjeta(id);
        }
    }
}
