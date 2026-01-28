using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class LoginClass
    {
        public bool ValidarUsuario(string usuario, string clave)
        {
            bool existe=false;
            
            using (SqlConnection cn= Conexion.obtenerConexion())
            {
                string slq = "SELECT COUNT(*) FROM usuarios WHERE name=@u AND contraseña=@c";
                SqlCommand cmd= new SqlCommand(slq, cn);

                cmd.Parameters.AddWithValue("@u",usuario);
                cmd.Parameters.AddWithValue("@c", clave);

                cn.Open();
                int count= (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    existe=true;
                }
            }
            return existe;
        }
    }
}
