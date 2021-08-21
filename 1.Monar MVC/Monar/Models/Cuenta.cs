using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Cuenta
  {
    private int cvu;
    private string alias;
    private decimal saldo;
    private int usuarioDni;
    private int tipoMoneda;

    public Cuenta()
    {
    }

    public Cuenta(int cvu, string alias, decimal saldo, int usuarioDni, int tipoMoneda)
    {
      this.cvu = cvu;
      this.alias = alias;
      this.saldo = saldo;
      this.usuarioDni = usuarioDni;
      this.tipoMoneda = tipoMoneda;
    }

    public int Cvu
    {
      get { return cvu; }
      set { cvu = value;}
    }
    
    public string Alias
    {
      get {return alias;}
      set {alias = value;}
    }

    public decimal Saldo
    {
      get {return saldo;}
      set {saldo = value;}
    }

    public int Usuario
    {
      get{return usuarioDni;}
      set {usuarioDni = value;}
    }

    public int TipoMoneda
    {
      get{return tipoMoneda;}
      set{tipoMoneda = value;}
    }
    /*
    [ForeignKey("usuario_dni")] 
     public virtual Usuario Usuarios { get; set; }
    */
  }
}
