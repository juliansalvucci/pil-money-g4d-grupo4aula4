using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Transferencia
  {
    private int id;
    private System.DateTime fecha;
    private System.TimeSpan hora;  //VER
    private string nota;
    private int cvu;
    private int destino;

    public Transferencia()
    {
    }

    public Transferencia(int id, System.DateTime fecha, System.TimeSpan hora, string nota, int cvu, int destino)
    {
      this.id = id;
      this.fecha = fecha;
      this.hora = hora;
      this.nota = nota;
      this.cvu = cvu;
      this.destino = destino;
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
      get { return hora; }
      set {; }
    }

    public string Nota
    {
      get { return nota; }
      set { nota = value; }
    }

    public int Cvu
    {
      get { return cvu; }
      set { cvu = value; }
    }
    
    public int Destino
    {
      get { return destino; }
      set { destino = value; }
    }
  }
}
