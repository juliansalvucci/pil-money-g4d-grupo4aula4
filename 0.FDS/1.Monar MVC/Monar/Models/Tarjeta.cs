using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Tarjeta
  {
    private long numero;
    private System.DateTime fechaVencimiento;
    private int codigoDeSeguridad;
    private string titular;


    public Tarjeta()
    {
    }

    public Tarjeta(long numero, System.DateTime fechaVencimiento, string titular, int codigoDeSeguridad)
    {
      this.numero = numero;
      this.fechaVencimiento = fechaVencimiento;
      this.titular = titular;
      this.codigoDeSeguridad = codigoDeSeguridad; 
    }

    [Required]
    public long Numero
    {
      get { return numero; }
      set { numero = value; }
    }

    [Required]
    public System.DateTime FechaVencimiento
    {
      get { return fechaVencimiento; }
      set {fechaVencimiento = value;}
    }

    [Required]
    public string Titular
    {
      get { return titular; }
      set {titular = value; }
    }


    [Required]
    public int CodigoSeguridad
    {
      get { return codigoDeSeguridad; }
      set { codigoDeSeguridad = value; }
    }
  }
}
