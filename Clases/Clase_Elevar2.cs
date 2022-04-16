using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNet6.Clases
{
    internal class Clase_Elevar2
    {
        //Clase que será usada para la operación elevar al cuadrado.
        public double Elevar(double Number1) //Creamos una función para elevar al cuadrado.
        {
            double Respuesta_Elevar;
            Respuesta_Elevar = Math.Pow(Number1, 2) ;

            return Respuesta_Elevar;
        }

    }
}
