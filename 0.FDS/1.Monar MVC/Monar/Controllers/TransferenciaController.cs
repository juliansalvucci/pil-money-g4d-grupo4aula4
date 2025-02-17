﻿using Monar.Models;
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
    public class TransferenciaController : ApiController
    {
        // GET: api/Transferencia
        public IEnumerable<Transferencia> Get()
        {
            GestorTransferencia gTransferencia = new GestorTransferencia();
            return gTransferencia.ListarTransferencias();
        }

        // GET: api/Transferencia/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Transferencia
        public HttpResponseMessage Post([FromBody]Transferencia value)
        {
            if (ModelState.IsValid)
            {
                GestorTransferencia gTransferencia = new GestorTransferencia ();
                gTransferencia.RegistrarTransferencia(value);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/Transferencia/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Transferencia/5
        public void Delete(int id)
        {
        }
    }
}
