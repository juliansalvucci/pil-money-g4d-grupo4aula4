using Monar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monar.Controllers
{
    public class TipoDepositoController : ApiController
    {
        // GET: api/TipoDeposito
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TipoDeposito/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoDeposito
        public HttpResponseMessage Post([FromBody]TipoDeposito value)
        {
            if (ModelState.IsValid)
            {
                GestorTipoDeposito gTipoDeposito = new GestorTipoDeposito();
                gTipoDeposito.RegistrarTipoDeposito(value);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/TipoDeposito/5
        public void Put(TipoDeposito td)
        {
            GestorTipoDeposito gTipoDeposito = new GestorTipoDeposito();
            gTipoDeposito.ModificarTipoDeposito(td);
        }

        // DELETE: api/TipoDeposito/5
        public void Delete(int id)
        {
            GestorTipoDeposito gTipoDeposito = new GestorTipoDeposito();
            gTipoDeposito.EliminarTipoDeposito(id);
        }
    }
}
