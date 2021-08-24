using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Monar.Models;
using System.Web.Routing;
using Microsoft.AspNetCore.Cors;

namespace Monar.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public HttpResponseMessage Post([FromBody]Usuario value)
        {
            if(ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            } 
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/Usuario/5
        public void Put(Usuario usuario)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            gUsuario.ModificarUsuario(usuario);
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
            GestorUsuario gUsuario= new GestorUsuario();
            gUsuario.EliminarUsuario(id);
        }
        

    }
}
