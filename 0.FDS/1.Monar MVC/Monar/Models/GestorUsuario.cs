﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml;
using BCrypt;

/*  GUÍA DE REFERENCIA
private int id;
private string apellido;
private string nombre;
private string contraseña;
private string correo;
private int dni;
private byte[] fotoFrenteDni;
private byte[] fotoDorsoDNI;
*/

namespace Monar.Models
{
    public class GestorUsuario
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarUsuario(Usuario nuevo)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(nuevo.Password);

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Usuario(apellido, nombre, password, correo, dni) VALUES (@Apellido, @Nombre, @Password, @Correo, @Dni)";
            cm.Parameters.Add(new SqlParameter("@Apellido", nuevo.Apellido));
            cm.Parameters.Add(new SqlParameter("@Nombre", nuevo.Nombre));
            cm.Parameters.Add(new SqlParameter("@Password", passwordHash));
            cm.Parameters.Add(new SqlParameter("@Correo", nuevo.Correo));
            cm.Parameters.Add(new SqlParameter("@Dni", nuevo.Dni));
            


            cm.ExecuteNonQuery();

            cx.Close();
        }

        public void ModificarUsuario(Usuario u)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE Usuario SET apellido=@Apellido, nombre=@Nombre, contraseña=@Contraseña, correo=@Correo WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", u.Id));
            cm.Parameters.Add(new SqlParameter("@Apellido", u.Apellido));
            cm.Parameters.Add(new SqlParameter("@Nombre", u.Nombre));
            cm.Parameters.Add(new SqlParameter("@Password", u.Password));
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