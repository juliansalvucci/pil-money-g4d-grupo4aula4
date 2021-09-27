using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*
 private int cvu;
 private string alias;
 private int saldo;
 private int usuarioDni;
 private int tipoMoneda;
 */

namespace Monar.Models
{
    public class GestorCuenta
    {
        private const string StrConexion = "Data Source=DESKTOP-0836GCF;Initial Catalog=Monar;Integrated Security=True";

        public void RegistrarCuenta(Cuenta nueva)
        {
            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "INSERT INTO Cuenta(cvu, alias, saldo, usuarioDni, tipoMoneda) VALUES (@Cvu, @Alias, @Saldo, @UsuarioDni, @TipoMoneda)";
            cm.Parameters.Add(new SqlParameter("@Cvu", nueva.Cvu));
            cm.Parameters.Add(new SqlParameter("@Alias", nueva.Alias));
            cm.Parameters.Add(new SqlParameter("@Saldo", nueva.Saldo));
            cm.Parameters.Add(new SqlParameter("@UsuarioDni", nueva.Usuario));
            cm.Parameters.Add(new SqlParameter("@TipoMoneda", nueva.TipoMoneda));
            
            cm.ExecuteNonQuery();

            cx.Close();
        }

        public List<Cuenta> ListarCuenta()
        {
            List<Cuenta> lista = new List<Cuenta>();

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Cuenta";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int cvu = dr.GetInt16(1);
                string alias = dr.GetString(2);
                double saldo = dr.GetDouble(3);
                int usuarioDni = dr.GetInt32(4);
                int tipoMoneda = dr.GetInt32(5);

                Cuenta c = new Cuenta(cvu, alias, saldo, usuarioDni, tipoMoneda);
                lista.Add(c);
            }

            dr.Close();
            cx.Close();

            return lista;
        }

        public Cuenta ObtenerCuentaPorId(int id)
        {
            Cuenta c = null;

            SqlConnection cx = new SqlConnection(StrConexion);
            cx.Open();

            SqlCommand cm = cx.CreateCommand();
            cm.CommandText = "SELECT * FROM Cuenta WHERE id=@Id";
            cm.Parameters.Add(new SqlParameter("@Id", id));

            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                int cvu = dr.GetInt16(1);
                string alias = dr.GetString(2);
                double saldo = dr.GetDouble(3);
                int usuarioDni = dr.GetInt32(4);
                int tipoMoneda = dr.GetInt32(5);

                c = new Cuenta(cvu, alias, saldo, usuarioDni, tipoMoneda);
            }

            dr.Close();
            cx.Close();

            return c;

        }
    }
}