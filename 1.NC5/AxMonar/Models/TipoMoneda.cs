﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar.Models
{
    public class TipoMoneda
    {
        [Key]
        public int IdTipoMoneda { get; set; }
        public string Nombre { get; set; }

    }
}
