using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class Destino
    {

        [Key]
        public string CvuAlias { get; set; }
        public string Propietario { get; set; }
        public string Correo { get; set; }
        public int Dni { get; set; }
    }
}
