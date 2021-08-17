using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Deposito
  {
    private int cvu;
    private string alias;
    private int saldo;
    private int usuario;
    private int tipoMoneda;

    public Deposito()
    {
    }

    public Deposito(int cvu, string alias, int saldo, int usuario, int tipoMoneda)
    {
      this.cvu = cvu;
      this.alias = alias;
      this.saldo = saldo;
      this.usuario = usuario;
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
    public int Saldo
    {
      get {return saldo;}
      set {saldo = value;}
    }
    public int Usuario
    {
      get{return usuario;}
      set {usuario = value;}
    }
    public int TipoMoneda
    {
      get{return tipoMoneda;}
      set{tipoMoneda = value;}
    }
  }
}
