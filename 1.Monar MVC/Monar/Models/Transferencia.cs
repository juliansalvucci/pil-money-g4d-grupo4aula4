using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Transferencia
  {
    private int id;
    private readonly DateTime date;
    private readonly DateTime time;  //VER
    private string nota;
    private int cvu;
    private int destino;

    public Transferencia()
    {
    }

    public Transferencia(int id, DateTime date, DateTime time, string nota, int cvu, int destino)
    {
      this.id = id;
      this.date = date;
      this.time = time;
      this.nota = nota;
      this.cvu = cvu;
      this.destino = destino;
    }

    public int Id
    {
      get { return id; }
      set { id = value; }
    }

    //FALTA FECHA Y HORA

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
