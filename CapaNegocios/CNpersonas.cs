using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNpersonas
    {
        LoginClass dal = new LoginClass();

        public bool Login(string usuario,string clave)
        {
            if(usuario==""|| clave == "")
            {
                return false;
            }
            return dal.ValidarUsuario(usuario, clave);
        }
    }
}
