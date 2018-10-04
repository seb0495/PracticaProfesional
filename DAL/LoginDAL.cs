using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {

        public LoginDAL() { }
        public int validarUsuario(string usuario, string clave)
        {
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = "prc_validarUsuario";
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            oCommand.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
            Conexion conn = new Conexion();
            DataTable table = new DataTable();
            table = conn.EjecutarProcedureTable(oCommand);
            int estadoUsuario = Convert.ToInt32(table.Rows[0][0].ToString());
            return estadoUsuario;
        }
    }
}
