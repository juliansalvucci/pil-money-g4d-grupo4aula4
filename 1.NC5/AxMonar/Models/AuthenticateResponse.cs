using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class AuthenticateResponse
    {
        public int Dni { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(Usuario usuario, string token)
        {
            Dni = usuario.Dni;
            Token = token;
        }
    }
}
