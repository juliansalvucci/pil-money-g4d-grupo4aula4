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
        public void ModificarEmpresa(Empresa e)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "UPDATE Empresa SET nombre=@Nombre WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", e.Id));
            cm.Parameters.Add(new SqlParameter("@Nombre", e.Nombre));

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

        public List<Empresa> ListarEmpresas()
        {
            List<Empresa> listadoEmpresas = new List<Empresa>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Empresa";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                
                Empresa e = new Empresa(id, nombre);
                listadoEmpresas.Add(e);
            }

            dr.Close();
            cx.Close();

            return listadoEmpresas;
        }
    }
}
