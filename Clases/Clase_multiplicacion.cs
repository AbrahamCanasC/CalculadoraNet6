using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNet6.Clases
{
    internal class Clase_multiplicacion
    {
        //Clase que serà usada para la operaciòn multiplicacion.
        public double Multiplicacion (double Number1, double Number2) //Creamos una función para la multiplicacion con dos paràmetros.
        {
            double Respuesta_Multi;
            Respuesta_Multi = Number1 * Number2;

            return Respuesta_Multi;
        }
    }
}
