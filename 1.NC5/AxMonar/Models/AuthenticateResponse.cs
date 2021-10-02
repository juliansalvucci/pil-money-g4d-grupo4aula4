using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class AuthenticateResponse
    {
        
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Password { get; set; }

        public string Correo { get; set; }

        public int Dni { get; set; }

        public string Token { get; set; }

        public AuthenticateResponse(Usuario usuario, string token)
        {
            Apellido = usuario.Apellido;
            Nombre = usuario.Nombre;
            Password = usuario.Password;
            Correo = usuario.Correo;
            Dni = usuario.Dni;
            Token = token;
        }
    }
}
