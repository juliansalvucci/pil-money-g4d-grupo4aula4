using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class Destino
    {

        [Key]
        public string AliasDestino { get; set; }

        [Required]
        public string Propietario { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public int DniDestino { get; set; }
    }
}
