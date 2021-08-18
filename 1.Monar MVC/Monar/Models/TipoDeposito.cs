using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class TipoDeposito
  {
    private int id;
    private string nombre;

    public TipoDeposito()
    {
    }

    public TipoDeposito(int id, string nombre)
    {
      this.id = id;
      this.nombre = nombre;
    }

    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }
  }
}
