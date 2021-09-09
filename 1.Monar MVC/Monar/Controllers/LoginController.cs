using Monar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Monar.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

        [HttpPost]
        /*
        [Route("authenticate")]
        */
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //TODO: Validate credentials Correctly, this code is only for demo !!
            //bool isCredentialValid = (login.Contraseña == "123456");

            GestorLogin gLogin = new GestorLogin();
            bool isCredentialValid = gLogin.ValidarLogin(login);

            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Correo, login.Contraseña);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
