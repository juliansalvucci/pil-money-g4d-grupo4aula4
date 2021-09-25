using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Monar.Models;
using System.Web.Routing;
using System.Web.Http.Cors;

namespace Monar.Controllers
{
    [RoutePrefix("api/Usuario")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuarioController : ApiController
    {
        
        // POST: api/Usuario
        public HttpResponseMessage Post([FromBody]Usuario value)
        {
            if(ModelState.IsValid)
            { 
                GestorUsuario gUsuario = new GestorUsuario();
                gUsuario.RegistrarUsuario(value);
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

        //AUTENTICACIÓN

       



    }
}
