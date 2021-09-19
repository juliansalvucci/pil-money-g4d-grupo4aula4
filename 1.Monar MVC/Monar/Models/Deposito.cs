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
    private long cvu;
    private long tarjeta;
    private float monto;
    

    public Deposito()
    {
    }

    public Deposito(int id, System.DateTime fecha, System.TimeSpan hora,long cvu, long tarjeta, float monto)
    {
      this.id = id;
      this.fecha = fecha;
      this.hora = hora;
      this.cvu = cvu;
      this.tarjeta = tarjeta;
      this.monto = monto;
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
    public int Cvu
    {
      get { return cvu; }
      set { cvu = value; }
    }

  
    [Required]
    public int Tarjeta
    {
      get { return tarjeta; }
      set { tarjeta = value; }
    } 

    [Required]
    public float Monto
    {
      get { return monto; }
      set { monto = value; }
    }
  }
}
