using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*GUÍA DE REFERENCIA
 private string aliascvu; //DEFINIR BIEN EL TIPO DE DATO
 private string propietario; //PARA PENSAR
 private string correo;
 private int dni;
 */

namespace Monar.Models
{
    public class GestorDestino  //¿SE MODIFICA?
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";
        public void RegistrarDestino(Destino nuevo)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Destino(cvuAlias, propietario, correo, dni) VALUES (@CvuAlias, @Propietario, @Correo, @Propietario, @Dni)";
            cm.Parameters.Add(new SqlParameter("@Aliascvu", nuevo.CvuAlias));
            cm.Parameters.Add(new SqlParameter("@Propietario", nuevo.Propietario));
            cm.Parameters.Add(new SqlParameter("@Correo", nuevo.Correo));
            cm.Parameters.Add(new SqlParameter("@Dni", nuevo.Dni));


            cm.ExecuteNonQuery();

            cx.Close();
        }

        public void EliminarDestino(int id)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "DELETE FROM Destino WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            cm.ExecuteNonQuery();

            cx.Close();

        }

        public Destino ObtenerDestinoPorId(int id)
        {
            Destino d = null;

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Destino WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string aliasCvu = dr.GetString(1);
                string propietario = dr.GetString(2);
                string correo = dr.GetString(3);
                int dni = dr.GetInt32(0);

                d = new Destino(aliasCvu, propietario, correo, dni);
            }

            dr.Close();
            cx.Close();

            return d;

        }


        public List<Destino> ListarDestinos()
        {
            List<Destino> listadoDestinos = new List<Destino>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Destino";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                string aliasCvu = dr.GetString(1);
                string propietario = dr.GetString(2);
                string correo = dr.GetString(3);
                int dni = dr.GetInt32(4);

                Destino d = new Destino(aliasCvu, propietario, correo, dni);
                listadoDestinos.Add(d);
            }

            dr.Close();
            cx.Close();

            return listadoDestinos;
        }

    }
}