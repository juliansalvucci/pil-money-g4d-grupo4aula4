using Monar.Models;
using Newtonsoft.Json;
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
    public class CuentaController : ApiController
    {
        // GET: api/Cuenta
        [HttpGet]
        public IEnumerable<Cuenta> Get()
        {
            GestorCuenta gCuenta = new GestorCuenta();
            return gCuenta.ListarCuenta();
        }

        // GET: api/Cuenta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cuenta
        public void Post([FromBody]Cuenta nueva)
        {
            GestorCuenta gCuenta = new GestorCuenta();
            gCuenta.RegistrarCuenta(nueva);
        }

        // PUT: api/Cuenta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cuenta/5
        public void Delete(int id)
        {
        }
    }
}
