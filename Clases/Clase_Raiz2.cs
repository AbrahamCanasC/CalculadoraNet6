using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNet6.Clases
{
    internal class Clase_Raiz2
    {
        //Clase que será usada para la operación elevar al cuadrado.
        public double Raiz(double Number1) //Creamos una función para extraer raíz cuadrada.
        {
            double Respuesta_Raiz;
            Respuesta_Raiz = Math.Sqrt(Number1);

            return Respuesta_Raiz;
        }
    }
}
