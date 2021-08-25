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
    public class GestorEmpresa
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarEmpresa(Empresa nueva)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Empresa(nombre) VALUES (@Nombre)";
            cm.Parameters.Add(new SqlParameter("@Nombre", nueva.Nombre));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void ModificarEmpresa(TipoDeposito td)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE Empresa SET nombre=@Nombre WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", td.Id));
            cm.Parameters.Add(new SqlParameter("@Nombre", td.Nombre));

            cm.ExecuteNonQuery();

            cx.Close();
        }
        public void EliminarEmpresa(int id)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "DELETE FROM Empresa WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            cm.ExecuteNonQuery();

            cx.Close();

        }
    }
}
