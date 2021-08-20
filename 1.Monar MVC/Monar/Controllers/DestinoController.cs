using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monar.Controllers
{
    public class DestinoController : ApiController
    {
        // GET: api/Destino
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Destino/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Destino
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Destino/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Destino/5
        public void Delete(int id)
        {
        }
    }
}
