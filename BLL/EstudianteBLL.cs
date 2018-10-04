using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data;

namespace BLL
{
    public class EstudianteBLL
    {
        public EstudianteBLL() { }

        public int guardarEstudiante(Estudiante estudiante)
        {
            int estado = -2;
            EstudianteDAL estDal = new EstudianteDAL();
            try
            {

                estado = estDal.guardarEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return estado;

        }

        public Estudiante buscarEstudianteCed(string cedula)
        {
            DataTable tableEst = new DataTable();
            EstudianteDAL estDal = new EstudianteDAL();
            tableEst = estDal.buscarEstudianteCed(cedula);
            Estudiante estudiante = new Estudiante();
            //recorrer tabla y popular objeto estudiante
            DataRow row = tableEst.NewRow();
            row = tableEst.Rows[0];
            string nombre = row.Field<string>("nombre");
            string fechaExp = row.Field<DateTime>("fechaExped").ToShortDateString();
            string fechaVenc = row.Field<DateTime>("fechaVenc").ToShortDateString();
            string primerApellido = row.Field<string>("primerApellido");
            string segundoApellido = row.Field<string>("segundoApellido");
            string genero = row.Field<string>("genero");
            int nacionalidad = row.Field<int>("idNacionalidad");
            string fechaNac = row.Field<DateTime>("fechaNacimiento").ToShortDateString(); 

            estudiante.cedula = cedula;
            estudiante.nombre = nombre;
            estudiante.primerApellido = primerApellido;
            estudiante.fechaExped = Convert.ToDateTime(fechaExp);
            estudiante.fechaNacimiento = Convert.ToDateTime(fechaNac);
            estudiante.fechaVenc = Convert.ToDateTime(fechaVenc);
            estudiante.genero = Convert.ToChar(genero);
            estudiante.idNacionalidad = nacionalidad;
            estudiante.segundoApellido = segundoApellido;

            return estudiante;
            
              
        }

        public int eliminarEstudiante(string cedula)
        {
            try
            {
                EstudianteDAL estDal = new EstudianteDAL();
                return estDal.eliminarEstudiante(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable cargarNacionalidades()
        {
            EstudianteDAL estDal = new EstudianteDAL();
            try
            {
                return estDal.cargarNacionalidades();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
