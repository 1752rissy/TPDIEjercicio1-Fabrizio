using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            Profesor profesor = new Profesor();
            Materia materia = new Materia();
            Wrapper wr = new Wrapper(alumno);
            Wrapper wr1 = new Wrapper(profesor);
            Wrapper wr2 = new Wrapper(materia);
            wr.TrabajarConEliminar();
            wr1.TrabajarConInsertar();
            wr2.TrabajarConModificar();


            
        }
    }
}
