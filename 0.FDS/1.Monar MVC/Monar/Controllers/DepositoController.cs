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
    public class DepositoController : ApiController
    {
        // GET: api/Deposito
        public IEnumerable<Deposito> Get()
        {
            GestorDeposito gDeposito = new GestorDeposito();
            return gDeposito.ListarDepositos();
        }

        // GET: api/Deposito/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Deposito
        public void Post([FromBody]Deposito nuevo)
        {
            GestorDeposito gDeposito = new GestorDeposito();
            gDeposito.RegistrarDeposito(nuevo);
        }

        // PUT: api/Deposito/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Deposito/5
        public void Delete(int id)
        {
        }
    }
}
