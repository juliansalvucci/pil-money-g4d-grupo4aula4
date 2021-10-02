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
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";
        public void RegistrarTarjeta(Tarjeta nueva)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Tarjeta(numero, fechaVencimiento, codigoDeSeguridad, titular) VALUES (@Numero, @FechaVencimiento, @CodigoDeSeguridad, @Titular)";
            cm.Parameters.Add(new SqlParameter("@Numero", nueva.Numero));
            cm.Parameters.Add(new SqlParameter("@FechaVencimiento", nueva.FechaVencimiento));
            cm.Parameters.Add(new SqlParameter("@Titular", nueva.Titular));
            cm.Parameters.Add(new SqlParameter("@CodigoDeSeguridad", nueva.CodigoSeguridad));
            
            


            cm.ExecuteNonQuery();

            cx.Close();
        }

        public void ModificarTarjeta(Tarjeta t)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE Tarjeta SET numero=@Numero, fechaVencimiento=@FechaVencimiento, codigoSeguridad=@CodigoDeSeguridad, titular=@Titular WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Numero", t.Numero));
            cm.Parameters.Add(new SqlParameter("@FechaVencimiento", t.FechaVencimiento));
            cm.Parameters.Add(new SqlParameter("@Titular", t.Titular));
            cm.Parameters.Add(new SqlParameter("@CodigoDeSeguridad", t.CodigoSeguridad));
            
            


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

        public List<Tarjeta> ListarTarjetas()
        {
            List<Tarjeta> listadoTarjetas = new List<Tarjeta>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Tarjeta";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                int numero = dr.GetInt32(1);
                System.DateTime fechaVencimiento = dr.GetDateTime(2);
                string titular = dr.GetString(3);
                int codigoDeSeguridad = dr.GetInt32(4);
                
                Tarjeta t = new Tarjeta(numero, fechaVencimiento, titular, codigoDeSeguridad);
                listadoTarjetas.Add(t);
            }

            dr.Close();
            cx.Close();

            return listadoTarjetas;
        }
    }
}