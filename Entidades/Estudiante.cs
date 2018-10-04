using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        public string cedula { set; get; }
        public DateTime fechaExped { set; get; }
        public DateTime fechaVenc { set; get; }
        public string nombre { set; get; }
        public string primerApellido { set; get; }
        public string segundoApellido { set; get; }
        public char genero { set; get; }
        public int idNacionalidad { set; get; }
        public int edad { set; get; }
        public DateTime fechaNacimiento { set; get; }

        public Estudiante() { }
    }
}

