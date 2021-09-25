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
    private string password;
    private string correo;
    private int dni;
   
   

    public Usuario()
    {
    }

    public Usuario(int id, string apellido, string nombre, string password, string correo, int dni)
    {
      this.id = id;
      this.apellido = apellido;
      this.nombre = nombre;
      this.password = password;
      this.correo = correo;
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
    public string Password
    {
      get { return password; }
      set { password = value; }
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
  }
}
