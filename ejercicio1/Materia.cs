using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Materia: IABM
    {
        public string nombreMateria { get; set; }

        public string Eliminar()
        {
            return "Eliminando Materia";
        }

        public string Insertar()
        {
            return "Insertando Materia...";
        }

        public string Modificar()
        {
            return "Modificando Materia...";
        }
    }
}
