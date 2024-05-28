using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises.Recursividad
{
    
    internal class TriangularNumber
    {
        //para obtener el numero triangular seria la suma de n,n-1.....1
        public int TriangularNumberExcercise(int n) {

            //una vez que n sea igual a 1 se para el ciclo y regresaremos n
            if (n == 1)
            {
                return n;
            }

            //sumaremos el n actual con el n-1 continuamente
            return (n + TriangularNumberExcercise(n - 1));
        }
    }
}
