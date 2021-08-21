using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

/*  GUÍA DE REFERENCIA
this.id = id;
this.apellido = apellido;
this.nombre = nombre;
this.contraseña = contraseña;
this.correo = correo;
this.fotoFrenteDni = fotoFrenteDni;
this.fotoDorsoDNI = fotoDorsoDNI;
*/

namespace Monar.Models
{
    public class GestorUsuario
    {
        private const string StrConexion = "Server=LAPTOP-0CRE86U4\\SQLEXPRESS;Database=Personas;User Id=sa;Password=123456;";

        public void RegistrarUsuario(Usuario nuevo)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Usuario(apellido, nombre, contraseña, correo, fotoFrenteDni, fotoDorsoDni) VALUES (@Apellido, @Nombre, @Contraseña, @Correo, @FotoFrenteDni, @FotoDorsoDni)";
            cm.Parameters.Add(new SqlParameter("@Apellido", nuevo.Apellido));
            cm.Parameters.Add(new SqlParameter("@Nombre", nuevo.Nombre));
            cm.Parameters.Add(new SqlParameter("@Contraseña", nuevo.Contraseña));
            cm.Parameters.Add(new SqlParameter("@Correo", nuevo.Correo));
            cm.Parameters.Add(new SqlParameter("@fotoFrenteDni", nuevo.FotoFrenteDNI));
            cm.Parameters.Add(new SqlParameter("@fotoDorsoDni", nuevo.FotoDorsoDNI));


            cm.ExecuteNonQuery();

            cx.Close();
        }

        public void ModificarUsuario(Usuario u)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE Personas SET apellido=@Apellido, nombre=@Nombre, contraseña=@Contraseña, correo=@cCorreo WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", u.Id));
            cm.Parameters.Add(new SqlParameter("@Apellido", u.Apellido));
            cm.Parameters.Add(new SqlParameter("@Nombre", u.Nombre));
            cm.Parameters.Add(new SqlParameter("@Contraseña", u.Contraseña));
            cm.Parameters.Add(new SqlParameter("@Correo", u.Correo));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void EliminarUsuario(int id)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "DELETE FROM Usuario WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            cm.ExecuteNonQuery();

            cx.Close();

        }
    }
}