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
    public class GestorTipoDeposito
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarTipoDeposito(TipoDeposito nuevo)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO TipoDeposito(nombre) VALUES (@Nombre)";
            cm.Parameters.Add(new SqlParameter("@Nombre", nuevo.Nombre));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void ModificarTipoDeposito(TipoDeposito td)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE TipoDeposito SET nombre=@Nombre WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", td.Id));
            cm.Parameters.Add(new SqlParameter("@Nombre", td.Nombre));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void EliminarTipoMoneda(int id)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "DELETE FROM TipoDeposito WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            cm.ExecuteNonQuery();

            cx.Close();

        }
    }
}