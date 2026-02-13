using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNHabitaciones
    {
        CDHabitaciones dal = new CDHabitaciones();

        public DataTable LoadHabitaciones()
        {
           return dal.ObtenerHabitaciones();
        }

        public bool agregarHabitacion(int numero, string descripcion, int cantidad)
        {
            return dal.AgregarHabitacion(numero, descripcion, cantidad);
        }

        public bool ModificarHabitacion(int id,int numero, string descripcion, int cantidad)
        {
            return dal.ModificarHabitacion(id,numero, descripcion, cantidad);
        }

        public bool EliminarHabitacion(int id)
        {
            return dal.EliminarHabitacion(id);
        }

    }
}
