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

        //Mapeo de modelos a base de datos
        public DbSet<Cuenta> Cuenta { get; set; }

        public DbSet<Deposito> Deposito { get; set; }

        public DbSet<Destino> Destino { get; set; }

        public DbSet<TipoMoneda> TipoMoneda { get; set; }

        public DbSet<Transferencia> Transferencia { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
