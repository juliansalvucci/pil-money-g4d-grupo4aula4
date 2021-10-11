using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Empresa
  {
    private int id;
    private string nombre;

    public Empresa()
    {
    }

    public Empresa(int id, string nombre)
    {
      this.id = id;
      this.nombre = nombre;
    }

    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    
    [Required]
    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }
  }
}
