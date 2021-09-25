using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
    public class LoginRequest
    {
        private string correo;
        private string password;
        

        public LoginRequest() 
        {
        }

        [Required]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [Required]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}