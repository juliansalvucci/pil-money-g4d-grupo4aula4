using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Deposito
  {
    private int id;
    private readonly System.DateTime fecha;
    private readonly System.TimeSpan hora;  
    private int tipoDeposito;
    private int tarjeta;
    private int cvu;
    private int codigoSeguridad; //SE DEBE GENERAR DE FORMA ALEATORIA

    public Deposito()
    {
    }

    public Deposito(int id, System.DateTime fecha, System.TimeSpan hora, int tipoDeposito, int tarjeta, int cvu, int codigoSeguridad)
    {
      this.id = id;
      this.fecha = fecha;
      this.hora = hora;
      this.tipoDeposito = tipoDeposito;
      this.tarjeta = tarjeta;
      this.cvu = cvu;
      this.codigoSeguridad = codigoSeguridad;
    }

    public int Id
    {
      get { return id; }
      set { id = value; }
    }

    public System.DateTime Fecha
    {
      get { return fecha; }
      set {; }
    }


    public System.TimeSpan Hora
    {
      get { return hora;}
      set { ;}
    }

    public int TipoDeposito
    {
      get { return tipoDeposito; }
      set { tipoDeposito = value; }
    }
    public int Tarjeta
    {
      get { return tarjeta; }
      set { tarjeta = value; }
    }
    public int Cvu
    {
      get { return cvu; }
      set { cvu = value; }
    }
    public int CodigoSeguridad
    {
      get { return codigoSeguridad; }
      set { codigoSeguridad = value; }
    }
  }
}
