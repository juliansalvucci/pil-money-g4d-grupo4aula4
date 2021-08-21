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
        private const string StrConexion = "Server=LAPTOP-0CRE86U4\\SQLEXPRESS;Database=Personas;User Id=sa;Password=123456;";

        public void RegistrarDeposito(Deposito nuevo)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Deposito(fecha, hora, tipoDeposito, tarjeta, cvu, codigoSeguridad) VALUES (@Fecha, @Hora, @TipoDeposito, @Tarjeta, @Cvu, @CodigoSeguridad)";
            cm.Parameters.Add(new SqlParameter("@Fecha", nuevo.Fecha));
            cm.Parameters.Add(new SqlParameter("@Hora", nuevo.Hora));
            cm.Parameters.Add(new SqlParameter("@TipoDeposito", nuevo.TipoDeposito));
            cm.Parameters.Add(new SqlParameter("@Tarjeta", nuevo.Tarjeta));
            cm.Parameters.Add(new SqlParameter("@Cvu", nuevo.Cvu));
            cm.Parameters.Add(new SqlParameter("@CodigoSeguridad", nuevo.CodigoSeguridad));

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
                int tipoDeposito = dr.GetInt32(3);
                int tarjeta = dr.GetInt32(4);
                int cvu = dr.GetInt32(5);
                int codigoSeguridad = dr.GetInt32(5);

                Deposito d = new Deposito(id, fecha, hora, tipoDeposito, tarjeta, cvu, codigoSeguridad);
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
                System.DateTime fecha = dr.GetDateTime(1); //CONTROLAR SI EL TIPO GET ES CORRECTO
                System.TimeSpan hora = dr.GetTimeSpan(2);
                int tipoDeposito = dr.GetInt32(3);
                int tarjeta = dr.GetInt32(4);
                int cvu = dr.GetInt32(5);
                int codigoSeguridad = dr.GetInt32(5);

                d = new Deposito(id, fecha, hora, tipoDeposito, tarjeta, cvu, codigoSeguridad);
            }

            dr.Close();
            cx.Close();

            return d;

        }
    }
}