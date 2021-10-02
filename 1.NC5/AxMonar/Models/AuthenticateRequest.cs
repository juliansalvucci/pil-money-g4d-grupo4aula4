using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Correo { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
