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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TipoDeposito/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TipoDeposito/5
        public void Delete(int id)
        {
        }
    }
}
