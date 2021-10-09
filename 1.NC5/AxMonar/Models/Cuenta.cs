using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class Cuenta
    {
        [Key]
        [Required]
        public long Cvu { get; set; }

        [Required]
        public string Alias { get; set; }

        [Required]
        public double Saldo { get; set; }

        [Required]
        public int Dni { get; set; }

        [Required]
        public int IdTipoMoneda { get; set; }

    }
}
