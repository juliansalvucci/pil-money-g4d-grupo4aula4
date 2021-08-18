using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Deposito
  {
    private int id;
    private readonly DateTime date;
    private readonly DateTime time;  //VER
    private int tipoDeposito;
    private int tarjeta;
    private int cvu;
    private int codigoSeguridad; //SE DEBE GENERAR DE FORMA ALEATORIA

    public Deposito()
    {
    }

    public Deposito(int id, DateTime date, DateTime time, int tipoDeposito, int tarjeta, int cvu, int codigoSeguridad)
    {
      this.id = id;
      this.date = date;
      this.time = time;
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

    //FALTA FECHA Y HORA

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
