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
        public int Cvu { get; set; }

        [Required]
        public string Alias { get; set; }

        [Required]
        public double Saldo { get; set; }

        
        [Required]
        [ForeignKey("Dni")]
        public Usuario Usuario { get; set; }
        

        [Required]
        [ForeignKey("IdTipoMoneda")]
        public TipoMoneda TipoMoneda { get; set; }
    }
}
