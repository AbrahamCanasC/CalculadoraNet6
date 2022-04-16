using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNet6.Clases
{
    internal class Clase_Resta
    {
        //Clase que serà usada para la operaciòn resta.
        public double Restas (double Number1, double Number2) //Creamos una función para la resta con dos paràmetros.
            {
            double Respuesta_Resta;
            Respuesta_Resta = Number1-Number2;
            
            return Respuesta_Resta; 
            }
    }
}
