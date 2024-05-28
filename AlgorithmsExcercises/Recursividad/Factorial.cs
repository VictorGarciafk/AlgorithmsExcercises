using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises.Recursividad
{
    internal class Factorial
    {
        //para obtener el factorial de n numeros seria la multiplicacion de los n numeros hasta 1
        public int factorialExcercise(int n)
        {
            //una vez nuestra n sea 1 retornamos ese valor
            if (n == 1)
            {
                return n;
            }
            //multiplicamos el valor actual de n por n - 1 y retornamos el valor
            return (n * factorialExcercise(n - 1));
        }
    }
}
