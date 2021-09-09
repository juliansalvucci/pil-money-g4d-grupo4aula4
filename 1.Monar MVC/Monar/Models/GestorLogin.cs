using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
            cm.CommandText = "SELECT correo, contraseña FROM Usuario WHERE @Correo=correo AND @Contraseña=contraseña";
            cm.Parameters.Add(new SqlParameter("@Correo", login.Correo));
            cm.Parameters.Add(new SqlParameter("@Contraseña", login.Contraseña));

            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}