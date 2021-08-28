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
                int codigoDeSeguridad = dr.GetInt32(3);
                string propietario = dr.GetString(4);
                int dni = dr.GetInt32(5);
                int empresa = dr.GetInt32(6);

                Tarjeta t = new Tarjeta(numero, fechaVencimiento, codigoDeSeguridad, propietario, dni,empresa);
                listadoTarjetas.Add(t);
            }

            dr.Close();
            cx.Close();

            return listadoTarjetas;
        }
    }
}