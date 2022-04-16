using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNet6.Clases
{
    internal class Clase_Cambio_Signo
    {
        //Clase que será usada para la operaciòn cambiar signo a número.
        public double Cambio_Signo(double Number1) //Creamos una función para el cambio de signo con un paràmetro.
        {
            double Respuesta_Cambio;
            Respuesta_Cambio = Number1 * (-1);

            return Respuesta_Cambio;
        }
    }
}
