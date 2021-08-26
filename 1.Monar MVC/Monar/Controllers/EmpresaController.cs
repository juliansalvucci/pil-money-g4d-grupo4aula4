using Monar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monar.Controllers
{
    public class EmpresaController : ApiController
    {
        // GET: api/Empresa
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Empresa/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Empresa
        public HttpResponseMessage Post([FromBody]Empresa value)
        {
            if (ModelState.IsValid)
            {
                GestorEmpresa gEmpresa = new GestorEmpresa();
                gEmpresa.RegistrarEmpresa(value);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/Empresa/5
        public void Put(Empresa empresa)
        {
            GestorEmpresa gEmpresa = new GestorEmpresa();
            gEmpresa.ModificarEmpresa(empresa);
        }

        // DELETE: api/Empresa/5
        public void Delete(int id)
        {
            GestorEmpresa gEmpresa = new GestorEmpresa();
            gEmpresa.EliminarEmpresa(id);
        }
    }
}
