using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class Deposito
    {
        [Key]
        public int IdDeposito { get; set; }

        public System.DateTime Fecha { get; set; }

        [Required]
        public float Monto { get; set; }

        [Required]
        public long Cvu { get; set; }
    }
}
