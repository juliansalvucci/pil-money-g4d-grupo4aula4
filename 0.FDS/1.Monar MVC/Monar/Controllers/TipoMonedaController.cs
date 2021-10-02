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
    public class TipoMonedaController : ApiController
    {
        // GET: api/TipoMoneda
        public IEnumerable<TipoMoneda> Get()
        {
            GestorTipoMoneda gTipoMoneda = new GestorTipoMoneda();
            return gTipoMoneda.ListarTiposDeMonedas();
        }

        // GET: api/TipoMoneda/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoMoneda
        public HttpResponseMessage Post([FromBody]TipoMoneda value)
        {
            if (ModelState.IsValid)
            {
                GestorTipoMoneda gTipoMoneda = new GestorTipoMoneda();
                gTipoMoneda.RegistrarTipoMoneda(value);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/TipoMoneda/5
        public void Put(TipoMoneda tm)
        {
            GestorTipoMoneda gTipoMoneda = new GestorTipoMoneda();
            gTipoMoneda.ModificarTipoMoneda(tm);
        }

        // DELETE: api/TipoMoneda/5
        public void Delete(int id)
        {
            GestorTipoMoneda gTipoMoneda = new GestorTipoMoneda();
            gTipoMoneda.EliminarTipoMoneda(id);
        }
    }
}
