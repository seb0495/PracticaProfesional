using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class EstudianteDAL
    {
        public EstudianteDAL()
        {

        }

        public int guardarEstudiante(Estudiante estudiante)
        {
            int estado = -2;
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = "prc_insertarEstudiante";
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Parameters.AddWithValue("@cedula", estudiante.cedula);
            oCommand.Parameters.AddWithValue("@fechaExped", estudiante.fechaExped);
            oCommand.Parameters.AddWithValue("@fechaVenc", estudiante.fechaVenc);
            oCommand.Parameters.AddWithValue("@nombre", estudiante.nombre);
            oCommand.Parameters.AddWithValue("@primerApellido", estudiante.primerApellido);
            oCommand.Parameters.AddWithValue("@segundoApellido", estudiante.segundoApellido);
            oCommand.Parameters.AddWithValue("@genero", estudiante.genero);
            oCommand.Parameters.AddWithValue("@idNaciona", estudiante.idNacionalidad);
            oCommand.Parameters.AddWithValue("@fechaNac", estudiante.fechaNacimiento);
            try
            {
                Conexion conn = new Conexion();

                estado = conn.EjecutarSqlActualizacion(oCommand);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return estado;
        }

        public DataTable cargarNacionalidades()
        {

           

            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = "prc_selectNacionalidades";
            oCommand.CommandType = CommandType.StoredProcedure;
            Conexion conn = new Conexion();
            DataTable table = new DataTable();
            table = conn.EjecutarConsultaDataTable(oCommand);
            return table;
        }

        public DataTable buscarEstudianteCed(string cedula)
        {
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = "prc_buscarEstudianteCed";
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Parameters.AddWithValue("@cedula", cedula);
            Conexion conn = new Conexion();
            DataTable table = new DataTable();
            table = conn.EjecutarConsultaDataTable(oCommand);
            return table;
        }

        public int eliminarEstudiante(string cedula)
        {
            int resultado = -1;
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = "[prc_eliminarEstudiante]";
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Parameters.AddWithValue("@cedula", cedula);
            Conexion conn = new Conexion();
            resultado=conn.EjecutarSqlActualizacion(oCommand);
            return resultado;
        }

    }


}
