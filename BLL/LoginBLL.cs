using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        public LoginBLL() { }

        public int validarUsuario(string usuario, string clave)
        {
            int estado = -2;
            LoginDAL loginDAL = new LoginDAL();
            estado=loginDAL.validarUsuario(usuario, clave);
            return estado;
        }
    }
}
