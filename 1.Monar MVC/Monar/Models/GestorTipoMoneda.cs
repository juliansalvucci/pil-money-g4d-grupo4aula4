using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*GUÍA DE REFERENCIA
 private int id;
 private string nombre;
 */

namespace Monar.Models
{
    public class GestorTipoMoneda
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarTipoMoneda(TipoMoneda nuevo)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO TipoMoneda(nombre) VALUES (@Nombre)";
            cm.Parameters.Add(new SqlParameter("@Nombre", nuevo.Nombre));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void ModificarTipoMoneda(TipoMoneda tm)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE TipoMoneda SET nombre=@Nombre WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", tm.Id));
            cm.Parameters.Add(new SqlParameter("@Nombre", tm.Nombre));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void EliminarTipoMoneda(int id)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "DELETE FROM TipoMoneda WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            cm.ExecuteNonQuery();

            cx.Close();

        }

        public List<TipoMoneda> ListarTiposDeMonedas()
        {
            List<TipoMoneda> listadoTipoMonedas = new List<TipoMoneda>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM TipoMoneda";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string nombre = dr.GetString(1);

                TipoMoneda tm = new TipoMoneda(id, nombre);
                listadoTipoMonedas.Add(tm);
            }

            dr.Close();
            cx.Close();

            return listadoTipoMonedas;
        }
    }
}