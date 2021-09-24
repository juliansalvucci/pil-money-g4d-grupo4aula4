using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Monar.Models
{
    public class GestorLogin
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";
        public bool ValidarLogin(LoginRequest login)
        {


 
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT correo, contraseña FROM Usuario WHERE correo=@Correo";
            cm.Parameters.Add(new SqlParameter("@Correo", login.Correo));
           

            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                return BCrypt.Net.BCrypt.Verify(login.Contraseña, dr.GetString(1));
            }

            return false;
        }

       
    }
}