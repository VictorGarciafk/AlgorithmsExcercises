using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises.Recursividad
{
    internal class quickSorts
    {
        //nuestra lista de numeros a ordenar
        int[] numbers = { 9, 5, 25, 8, 2, 9, 32, 1, 10, 4, 3, 12 };
        public void printList(int[] numberlist)
        {
            foreach (int n in numberlist)
            {
                Console.Write(n.ToString() + ", ");
            }
            Console.WriteLine();
        }

        
    }
}
