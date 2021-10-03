using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        [Key]
        public int Dni { get; set; }

        [Required]
        public string Password { get; set; }


    }
}
