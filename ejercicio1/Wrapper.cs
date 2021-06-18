using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
   public class Wrapper 
    {
        private readonly IABM _operacionesABM;

        public Wrapper(IABM OperacionesABM) 
        {
            _operacionesABM = OperacionesABM;
        }

        public String TrabajarConInsertar()
        {
            return _operacionesABM.Insertar();
        }

        public string TrabajarConEliminar()
        {
            return _operacionesABM.Eliminar();
        }

        public string TrabajarConModificar()
        {
            return _operacionesABM.Modificar();
        }


    }
}
