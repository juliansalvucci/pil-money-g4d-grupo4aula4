using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/* GUÍA DE REFERNCIA
 this.id = id;
 this.fecha = fecha;
 this.hora = hora;
 this.nota = nota;
 this.cvu = cvu;
 this.destino = destino;
 */

namespace Monar.Models
{
    public class GestorTransferencia
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarTransferencia(Transferencia nueva)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Transferencia(fecha, hora, monto, nota, cvu, destino) VALUES (@Fecha, @Hora, @Monto, @Nota, @Cvu, @Destino)";
            cm.Parameters.Add(new SqlParameter("@Fecha", nueva.Fecha));
            cm.Parameters.Add(new SqlParameter("@Hora", nueva.Hora));
            cm.Parameters.Add(new SqlParameter("@Cvu", nueva.Cvu));
            cm.Parameters.Add(new SqlParameter("@Nota", nueva.Nota));
            cm.Parameters.Add(new SqlParameter("@Monto", nueva.Monto));
            cm.Parameters.Add(new SqlParameter("@Destino", nueva.Destino));
            
            cm.ExecuteNonQuery();

            cx.Close();
        }

        public List<Transferencia> ListarTransferencias()
        {
            List<Transferencia> lista = new List<Transferencia>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Transferencia";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                System.DateTime fecha = dr.GetDateTime(1); //CONTROLAR SI EL TIPO GET ES CORRECTO
                System.TimeSpan hora = dr.GetTimeSpan(2);
                int cvu = dr.GetInt32(3);
                string nota = dr.GetString(4);
                double monto = dr.GetDouble(5);
                int destino = dr.GetInt32(6);

                Transferencia t = new Transferencia(id, fecha, hora, cvu, nota, monto, destino);
                lista.Add(t);
            }

            dr.Close();
            cx.Close();

            return lista;
        }

        public Transferencia ObtenerTransferenciaPorId(int id)
        {
            Transferencia t = null;

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Transferencia WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                System.DateTime fecha = dr.GetDateTime(1); //CONTROLAR SI EL TIPO GET ES CORRECTO
                System.TimeSpan hora = dr.GetTimeSpan(2);
                int cvu = dr.GetInt32(5);
                string nota = dr.GetString(4);
                float monto = dr.GetFloat(3);
                int destino = dr.GetInt32(6);

                t = new Transferencia(id, fecha, hora, cvu, nota, monto, destino);
            }

            dr.Close();
            cx.Close();

            return t;

        }

    }

}