using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Tarjeta
  {
    private int numero;
    private DateTime date;
    private int codigoDeSeguridad;
    private string propietario;
    private int dni;
    private int empresa;

    public Tarjeta()
    {
    }

    public Tarjeta(int numero, DateTime date, int codigoDeSeguridad, string propietario, int dni,int empresa)
    {
      this.numero = numero;
      this.date = date;
      this.codigoDeSeguridad = codigoDeSeguridad;
      this.propietario = propietario;
      this.dni = dni;
      this.empresa = empresa;
    }

    public int Numero
    {
      get { return numero; }
      set { numero = value; }
    }

    //FALTA FECHA

    public int CodigoSeguridad
    {
      get { return codigoDeSeguridad; }
      set { codigoDeSeguridad = value; }
    }

    public string Propietario
    {
      get { return propietario; }
      set { propietario = value; }
    }

    public int Dni
    {
      get { return dni; }
      set { dni = value; }
    }

    public int Empresa
    {
      get { return empresa; }
      set { empresa = value; }
    }
  }
}
