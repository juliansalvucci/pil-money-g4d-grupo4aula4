using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class Transferencia
    {
        [Key]
        public int IdTransferencia { get; set; }

        public System.DateTime Fecha { get; set; }

        public System.TimeSpan Hora { get; set; }

        [Required]
        [ForeignKey("Cvu")]
        public Cuenta Cuenta { get; set; }

        public string Nota { get; set; }

        [Required]
        public double Monto { get; set; }

        [Required]
        [ForeignKey("CvuAlias")]
        public Destino Destino { get; set; }
    }
}
