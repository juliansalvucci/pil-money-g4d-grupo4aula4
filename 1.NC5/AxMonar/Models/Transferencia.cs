﻿using System;
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

        [Required]
        [ForeignKey("Cvu")]
        public long Cvu { get; set; }

        [Required]
        public double Monto { get; set; }

        public string Nota { get; set; }

        [Required]
        [ForeignKey("AliasDestino")]
        public string AliasDestino { get; set; }
    }
}
