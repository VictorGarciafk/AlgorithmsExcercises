using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises.Recursividad
{
    internal class cocktailSort
    {
        public List<int> cocktailSortExcercise(List<int> n, int inicio, int final)
        {
            //imprimimos toda la lista desordenada para poder verla en la terminal
            foreach (var item in n)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine("\n \n \n");

            int aux = 0;
            if (inicio >= final)
            {
                return n;
            }

            for (int i = inicio; i < final - 1; i++)
            {
                if (n[i] > n[i + 1])
                {
                    aux = n[i];
                    n[i] = n[i + 1];
                    n[i + 1] = aux;

                    foreach (var item in n)
                    {
                        Console.Write(item.ToString() + ", ");
                    }
                    Console.WriteLine("\n \n \n");
                }
            }

            Console.WriteLine("\n \n \n \n \n \n");
            for (int i = final - 1; i > inicio; i--)
            {
                if (n[i] < n[i - 1])
                {
                    aux = n[i];
                    n[i] = n[i - 1];
                    n[i - 1] = aux;

                    foreach (var item in n)
                    {
                        Console.Write(item.ToString() + ", ");
                    }
                    Console.WriteLine("\n \n \n");
                }
            }

            Console.WriteLine("\n \n \n \n \n \n \n \n \n");

            return cocktailSortExcercise(n, (inicio + 1), (final - 1));
        }

    }
}
