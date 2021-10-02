using AxMonar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AxMonar
{
    public class AplicacionDBContext: DbContext
    {
        public AplicacionDBContext(DbContextOptions<AplicacionDBContext> options) : base(options)
        {

        }
        DbSet<Cuenta> Cuenta { get; set; } //Mapeo de modelo a base de datos
        DbSet<Usuario> Usuario { get; set; }

    }
}
