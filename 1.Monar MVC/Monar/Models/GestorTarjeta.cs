using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*GUÍA DE REFERENCIA
 private int numero;
 private System.DateTime fechaVencimiento;
 private int codigoDeSeguridad;
 private string propietario;
 private int dni;
 private int empresa;
 */


namespace Monar.Models
{
    public class GestorTarjeta
    {
        private const string StrConexion = "Server=LAPTOP-0CRE86U4\\SQLEXPRESS;Database=Personas;User Id=sa;Password=123456;";
        public void RegistrarUsuario(Tarjeta nueva)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Tarjeta(numero, fechaVencimiento, codigoDeSeguridad, propietario, dni, empresa) VALUES (@Numero, @FechaVencimiento, @CodigoDeSeguridad, @Propietario, @Dni, @Empresa)";
            cm.Parameters.Add(new SqlParameter("@Numero", nueva.Numero));
            cm.Parameters.Add(new SqlParameter("@FechaVencimiento", nueva.FechaVencimiento));
            cm.Parameters.Add(new SqlParameter("@CodigoDeSeguridad", nueva.CodigoSeguridad));
            cm.Parameters.Add(new SqlParameter("@Propietario", nueva.Propietario));
            cm.Parameters.Add(new SqlParameter("@Dni", nueva.Dni));
            cm.Parameters.Add(new SqlParameter("@Empresa", nueva.Empresa));


            cm.ExecuteNonQuery();

            cx.Close();
        }

        public void EliminarTarjeta(int id)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "DELETE FROM Tarjeta WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            cm.ExecuteNonQuery();

            cx.Close();

        }
    }
}