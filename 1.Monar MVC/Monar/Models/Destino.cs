using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Destino
  {
    private string aliascvu; //DEFINIR BIEN EL TIPO DE DATO
    private string propietario; //PARA PENSAR
    private string correo;
    private int dni;

    public Destino()
    {
    }

    public Destino(string aliascvu, string propietario, string correo, int dni)
    {
      this.aliascvu = aliascvu;
      this.propietario = propietario;
      this.correo = correo;
      this.dni = dni;
    }

    public string Aliascvu
    {
      get { return aliascvu; }
      set { aliascvu = value; }
    }

    public string Propietario
    {
      get { return propietario; }
      set { propietario = value; }
    }

    public string Correo
    {
      get { return correo; }
      set { correo = value; }
    }
    
    public int Dni
    {
      get { return dni; }
      set { dni = value; }
    }
  }
}
