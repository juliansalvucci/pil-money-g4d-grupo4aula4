using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*GUÍA DE REFERENCIA
 private int id;
 private System.DateTime fecha;
 private System.TimeSpan hora;  
 private int tipoDeposito;
 private int tarjeta;
 private int cvu;
 private int codigoSeguridad;
 */

namespace Monar.Models
{
    public class GestorDeposito
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarDeposito(Deposito nuevo)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Deposito(fecha, hora, cvu, tarjeta, monto) VALUES (@Fecha, @Hora,  @Cvu,  @Tarjeta, @Monto)";
            cm.Parameters.Add(new SqlParameter("@Fecha", nuevo.Fecha));
            cm.Parameters.Add(new SqlParameter("@Hora", nuevo.Hora));
            cm.Parameters.Add(new SqlParameter("@Cvu", nuevo.Cvu));
            cm.Parameters.Add(new SqlParameter("@Tarjeta", nuevo.Tarjeta));
            cm.Parameters.Add(new SqlParameter("@Monto", nuevo.Monto));
            
            
            cm.ExecuteNonQuery();

            cx.Close();
        }

        public List<Deposito> ListarDepositos()
        {
            List<Deposito> lista = new List<Deposito>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Deposito";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                System.DateTime fecha = dr.GetDateTime(1); //CONTROLAR SI EL TIPO GET ES CORRECTO
                System.TimeSpan hora = dr.GetTimeSpan(2);
                long tarjeta = dr.GetInt32(3);
                long cvu = dr.GetInt32(4);
                float monto = dr.GetFloat(5);
               

                Deposito d = new Deposito(id, fecha, hora, cvu, tarjeta, monto);
                lista.Add(d);
            }

            dr.Close();
            cx.Close();

            return lista;
        }

        public Deposito ObtenerDepositoPorId(int id)
        {
            Deposito d = null;

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Deposito WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                int id = dr.GetInt32(0);
                System.DateTime fecha = dr.GetDateTime(1); //CONTROLAR SI EL TIPO GET ES CORRECTO
                System.TimeSpan hora = dr.GetTimeSpan(2);
                long tarjeta = dr.GetInt32(3);
                long cvu = dr.GetInt32(4);
                float monto = dr.GetFloat(5);
            
                Deposito d = new Deposito(id, fecha, hora, cvu, tarjeta, monto);
            }

            dr.Close();
            cx.Close();

            return d;
        }
    }
}