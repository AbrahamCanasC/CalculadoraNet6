using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNet6.Clases
{
    internal class Clase_Porcentaje
    {
        //Clase que serà usada para la operaciòn de porcentaje.
        public double Porcentaje(double Number1) //Creamos una función para el porcentaje con un paràmetro.
        {
            double Respuesta_Porcentaje;
            Respuesta_Porcentaje = Number1 / (100);

            return Respuesta_Porcentaje;
        }
    }
}
