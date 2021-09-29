using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Transferencia
  {
    private int id;
    private System.DateTime fecha;
    private System.TimeSpan hora;  //VER
    private int cvu;
    private string nota;
    private double monto;
    private int destino;

    public Transferencia()
    {
    }

    public Transferencia(int id, System.DateTime fecha, System.TimeSpan hora, int cvu, string nota, double monto , int destino)
    {
      this.id = id;
      this.fecha = fecha;
      this.hora = hora;
      this.cvu = cvu;
      this.nota = nota;
      this.monto = monto;
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

    [Required]
    public int Cvu
    {
      get { return cvu; }
      set { cvu = value; }
    }

    public string Nota
    {
      get { return nota; }
      set { nota = value; }
    }

    public double Monto
    {
      get {return monto;}
      set {monto = value;}
    }

   
    [Required]
    public int Destino
    {
      get { return destino; }
      set { destino = value; }
    }
  }
}
