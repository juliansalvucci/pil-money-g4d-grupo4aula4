using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Tarjeta
  {
    private int numero;
    private System.DateTime fechaVencimiento;
    private int codigoDeSeguridad;
    private string propietario;
    private int dni;
    private int empresa;

    public Tarjeta()
    {
    }

    public Tarjeta(int numero, System.DateTime fechaVencimiento, int codigoDeSeguridad, string propietario, int dni, int empresa)
    {
      this.numero = numero;
      this.fechaVencimiento = fechaVencimiento;
      this.codigoDeSeguridad = codigoDeSeguridad;
      this.propietario = propietario;
      this.dni = dni;
      this.empresa = empresa;
    }

    [Required]
    public int Numero
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
    public int CodigoSeguridad
    {
      get { return codigoDeSeguridad; }
      set { codigoDeSeguridad = value; }
    }

    [Required]
    public string Propietario
    {
      get { return propietario; }
      set { propietario = value; }
    }

    [Required]
    public int Dni
    {
      get { return dni; }
      set { dni = value; }
    }

    [Required]
    public int Empresa
    {
      get { return empresa; }
      set { empresa = value; }
    }
  }
}
