using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monar.Models
{
  public class Usuario
  {
    private int id;
    private string apellido;
    private string nombre;
    private string contraseña;
    private string correo;
    private int dni;
    private byte[] fotoFrenteDni;
    private byte[] fotoDorsoDNI;

    public Usuario()
    {
    }

    public Usuario(int id, string apellido, string nombre, string contraseña, string correo, int dni, byte[] fotoFrenteDni, byte[] fotoDorsoDNI)
    {
      this.id = id;
      this.apellido = apellido;
      this.nombre = nombre;
      this.contraseña = contraseña;
      this.correo = correo;
      this.fotoFrenteDni = fotoFrenteDni;
      this.fotoDorsoDNI = fotoDorsoDNI;
    }
    
    public int Id
    { 
      get { return id; }
      set { id = value; }
    }
    
    //[StringLength(60, MinimumLength = 3)]
    [Required]
    public string Apellido
    {
      get { return apellido; }
      set { apellido = value; }
    }

    [Required] 
    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    [Required]
    public string Contraseña
    {
      get { return contraseña; }
      set { contraseña = value; }
    }

    [Required]
    public string Correo
    {
      get { return correo; }
      set { correo = value; }
    }

    [Required]
    public int Dni
    { 
      get { return dni; }
      set { dni = value; }
    }

    public byte[] FotoFrenteDNI
    { 
      get { return fotoFrenteDni; }
      set { fotoFrenteDni = value; }
    }
    
    public byte[] FotoDorsoDNI
    { 
      get { return fotoDorsoDNI; }
      set { fotoDorsoDNI = value; }
    }
  }
}
