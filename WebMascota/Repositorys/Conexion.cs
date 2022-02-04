using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebMascota.Models;

namespace WebMascota.Repositorys
{
    public class Conexion
    {
        SqlConnection conn;

        private void Open()
        {
            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();
        }

        private void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public List<Mascota> Listar()
        {
            List<Mascota> list = new List<Mascota>();
            Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Mascotas", conn);
            SqlDataReader datos = command.ExecuteReader();
            while (datos.Read())
            {
                Mascota mascota = new Mascota();
                mascota.id = int.Parse(datos[0].ToString());
                mascota.name = datos[1].ToString();
                mascota.raza = datos[2].ToString();
                mascota.edad = int.Parse(datos[3].ToString());
                list.Add(mascota);
            }
            return list;
        }

        public int Agregar(Mascota mascota)
        {
            int result = 0;
            string query = "INSERT INTO Mascotas VALUES(@Name, @Raza, @Age)";
            Open();
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@Name", mascota.name);
                cmd.Parameters.AddWithValue("@Raza", mascota.raza);
                cmd.Parameters.AddWithValue("@Age", mascota.edad);
                cmd.Connection = conn;
                
                result = cmd.ExecuteNonQuery();
                
            }
            Close();
            return result;
        }
    }
}