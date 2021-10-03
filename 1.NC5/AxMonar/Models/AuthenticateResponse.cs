using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class AuthenticateResponse
    {
        public string Token { get; set; }

        public AuthenticateResponse(Usuario usuario, string token)
        { 
            Token = token;
        }
    }
}
