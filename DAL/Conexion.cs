using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Data;

namespace DAL
{
    public class Conexion
    {
        private static Conexion instance = null;
        public SqlConnection oConexion { set; get; }
        public Conexion()
        {
            establecerConexion();
        }

        public static Conexion getInstance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }

        public void establecerConexion()
        {

            String hileraConexion = "Data Source=DESKTOP-NVQ2E3K;Initial Catalog=DigEXP; Integrated Security=true";

            // oConexion = new SqlConnection(ayudante.ToString());
            oConexion = new SqlConnection(hileraConexion);
            try
            {
                oConexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error de conexión\n" + e.Message + "\n" + hileraConexion);
            }
        }



        //Método que permite ejecutar sentencia Insert,Delete,Update
        //Retorna la cantidad de registros insertados
        public Int32 EjecutarSqlActualizacion(String oSql)
        {
            Int32 vRegistrosActualizados = 0;
            try
            {

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;

                vRegistrosActualizados = oCommand.ExecuteNonQuery();

            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en Ejecutar sentencia SQL de actualización: \n" +
                                      errorSQL.Message + "\n" + oSql);
            }
            return vRegistrosActualizados;
        }




        //Método que permite ejecutar sentencia Insert,Delete,Update
        //Retorna la cantidad de registros insertados
        public Int32 EjecutarSqlActualizacion(SqlCommand oCommand)
        {
            Int32 vRegistrosActualizados = 0;
            oCommand.Connection = oConexion;
            try
            {
                vRegistrosActualizados = oCommand.ExecuteNonQuery();
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en Ejecutar sentencia SQL Actualización: \n" +
                                     errorSQL.Message + "\n" + oCommand.CommandText);
            }
            return vRegistrosActualizados;
        }



        //Método que permite ejecutar instrucciones Select 
        //Retorna el resultado en un objeto DataTable
        public DataTable EjecutarConsultaDataTable(String oSql)
        {
            DataTable oDataTable = new DataTable();
            SqlCommand oCommand = new SqlCommand();
            try
            {
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;

                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {
                    adaptador.Fill(oDataTable);
                }
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la consulta Data Table\n" +
                    errorSQL.Message + "\n" + oSql);
            }
            finally
            {
                oCommand = null;
            }
            return oDataTable;
        }

        public DataTable EjecutarConsultaDataTable(SqlCommand oCommand)
        {
            DataTable oDataTable = new DataTable();
            oCommand.Connection = oConexion;

            try
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {

                    adaptador.Fill(oDataTable);
                }
            }
            catch (Exception errorSQL)
            {

                throw new Exception("Error de SQL en la consulta DataTable\n" +
                                     errorSQL.Message + "\n" + oCommand.CommandText);
            }
            finally
            {
                oCommand = null;
            }
            return oDataTable;
        }


        //Método que permite ejecutar instrucciones Select 
        //Retorna el resultado en un objeto DataTable
        public DataSet EjecutarConsultaDataSet(String oSql)
        {
            DataSet dsTabla = new DataSet();

            try
            {

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;
                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {
                    adaptador.Fill(dsTabla);
                }
            }

            catch (Exception error)
            {
                throw new Exception("Error en Ejecutar SQL DataSet:\n" +
                                     error.Message + "\n" + oSql);
            }
            return dsTabla;
        }

        public DataSet EjecutarConsultaDataSet(SqlCommand oCommand)
        {
            DataSet dsTabla = new DataSet();

            try
            {

             
                oCommand.Connection = oConexion;
           
                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {
                    adaptador.Fill(dsTabla);
                }
            }

            catch (Exception error)
            {
                throw new Exception("Error en Ejecutar SQL DataSet:\n" +
                                     error.Message );
            }
            return dsTabla;
        }

        // Método que permite ejecutar sentencias SQL Escalares --> SUM, AVG, MIN, MAX, etc.
        //Retorna el único resultado que genera la consulta en una String
        public String EjecutarSQLScalar(String oSql)
        {
            //Declaración de variable para resultado del SqlScalar            
            String vResultadoScalar = "";
            try
            {
                // Creación del nuevo objeto tipo Command
                SqlCommand oCommand = new SqlCommand();

                //Asignación del objeto conexión, String SQL y tipo Command
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;

                //Ejecutar el SQL Escalar y retornar el valor 
                vResultadoScalar = oCommand.ExecuteScalar().ToString();
                //Retornar el resultado del SqlScalar
                return vResultadoScalar;
            }
            catch (Exception error)
            {
                throw new Exception("Error en Ejecutar SQL escalar:\n" +
                                      error.Message + "\n" + oSql);

            }

        }

        // Método que permite ejecutar sentencias SQL Escalares --> SUM, AVG, MIN, MAX, etc.
        //Retorna el único resultado que genera la consulta en una String
        public String EjecutarSQLScalar(SqlCommand oCommand)
        {

            //Declaración de variable para resultado del SqlScalar            
            String vResultadoScalar = "";

            try
            {
                //Asignación del objeto conexión, String SQL y tipo Command
                oCommand.Connection = oConexion;

                //Ejecutar el SQL Escalar y retornar el valor 
                vResultadoScalar = oCommand.ExecuteScalar().ToString();
                //Retornar el resultado del SqlScalar
                return vResultadoScalar;
            }
            catch (Exception error)
            {
                throw new Exception("Error en Ejecutar SQL escalar:\n" + error.Message +
                                     "\n" + oCommand.CommandText);

            }

        }

        public DataTable EjecutarProcedureTable(SqlCommand oCommand)
        {
            try
            {
                oCommand.Connection = oConexion;
                oCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = oCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception error)
            {
                throw new Exception("Error en Ejecutar SQL Procedure:\n" + error.Message +
                                     "\n" + oCommand.CommandText);

            }
        }


    }
}
