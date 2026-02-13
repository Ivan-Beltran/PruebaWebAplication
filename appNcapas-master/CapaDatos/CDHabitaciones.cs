using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDHabitaciones
    {
        public DataTable ObtenerHabitaciones()
        {
            DataTable dt=new DataTable();

            using (SqlConnection con= Conexion.obtenerConexion())
            {
                con.Open();
                using(SqlCommand cmd=new SqlCommand("SELECT * FROM Habitaciones", con))
                {
                    using(SqlDataAdapter da=new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            return dt;
        }

        public bool AgregarHabitacion(int numero,string descripcion, int cantidad)
        {
            using(SqlConnection con= Conexion.obtenerConexion())
            {
                con.Open();
                using(SqlCommand cmd=new SqlCommand("INSERT INTO Habitaciones (numero, descripcion, cant_huespedes) VALUES (@Numero, @Descripcion, @Cantidad)", con))
                {
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    int filasAfectadas= cmd.ExecuteNonQuery();
                    con.Close();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool ModificarHabitacion(int id, int numero, string descripcion, int cantidad)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Habitaciones set numero=@Numero, descripcion= @Descripcion, cant_huespedes=@Cantidad where id_habitaciones=@ID", con))
                {
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@ID",id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool EliminarHabitacion(int id)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Habitaciones where id_habitaciones=@ID", con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
