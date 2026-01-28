using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static string cadena = "Data Source=IVAN;Initial Catalog=LoginDb;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadena);   
        }
    }
}
