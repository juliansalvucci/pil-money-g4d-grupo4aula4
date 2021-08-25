using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Deposito
  {
    private int id;
    private System.DateTime fecha;
    private System.TimeSpan hora;  
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
      set { fecha = value; }
    }

    public System.TimeSpan Hora
    {
      get { return hora;}
      set { hora = value;}
    }

    [Required]
    public int TipoDeposito
    {
      get { return tipoDeposito; }
      set { tipoDeposito = value; }
    }
    
    [Required]
    public int Tarjeta
    {
      get { return tarjeta; }
      set { tarjeta = value; }
    }

    [Required]
    public int Cvu
    {
      get { return cvu; }
      set { cvu = value; }
    }
    
    [Required]
    public int CodigoSeguridad
    {
      get { return codigoSeguridad; }
      set { codigoSeguridad = value; }
    }
  }
}
