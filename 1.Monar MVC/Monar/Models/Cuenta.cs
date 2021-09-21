using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Monar.Models
{
  public class Cuenta
  {
    private long cvu;
    private string alias;
    private double saldo;
    private int usuarioDni;
    private int tipoMoneda;

    public Cuenta()
    {
    }

    public Cuenta(long cvu, string alias, double saldo, int usuarioDni, int tipoMoneda)
    {
      this.cvu = cvu;
      this.alias = alias;
      this.saldo = saldo;
      this.usuarioDni = usuarioDni;
      this.tipoMoneda = tipoMoneda;
    }

    public long Cvu
    {
      get { return cvu; }
      set { cvu = value;}
    }
    
    [Required]
    public string Alias
    {
      get {return alias;}
      set {alias = value;}
    }

    public double Saldo
    {
      get {return saldo;}
      set {saldo = value;}
    }

    [Required]
    public int Usuario
    {
      get{return usuarioDni;}
      set {usuarioDni = value;}
    }

    [Required]
    public int TipoMoneda
    {
      get{return tipoMoneda;}
      set{tipoMoneda = value;}
    }
  }
}
