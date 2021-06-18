using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Alumno:IABM
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string dni { get; set; }

        public string Eliminar()
        {
            return "Eliminando alumno...";
        }

        public string Insertar()
        {
            return "Insertando alumno...";
        }

        public string Modificar()
        {
            return "Modificando Alumno...";
        }
    }
}
