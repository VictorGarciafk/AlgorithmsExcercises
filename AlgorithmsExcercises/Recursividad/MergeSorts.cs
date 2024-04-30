using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises.Recursividad
{
    internal class MergeSorts
    {
        //metodo para imprimir
        public void printList(List<int> numberlist)
        {
            foreach (int n in numberlist)
            {
                Console.Write(n.ToString() + ", ");
            }
            
        }
        public List<int> MergeSort(List<int> n)
        {
            //creamos dos lista donde almacenaremos cada mitad de la lista
            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();

            //creamos dos lista donde almacenaremos cada mitad de la lista ya resuelta
            List<int> sortedListOne = new List<int>();
            List<int> sortedListTwo = new List<int>();

            //si la lista que recibimos solo tiene un elemento, directamente se retornara
            if (n.Count == 1)
            {
                return n;
            }

            //almacenamos en la variable la primera mitad de la lista
            for (int i = 0; i < n.Count/2; i++)
            {
                listOne.Add(n[i]);
            }
            //almacenamos en la segunda variable la segunda mitad de la lista
            for (int i = (n.Count / 2); i < n.Count; i++)
            {
                listTwo.Add(n[i]);
            }

            //mandamos nuestra mitad de nuevo al metodo para seguir dividiendo la lista hasta tener valores
            //individuales
            sortedListOne = MergeSort(listOne);
            sortedListTwo = MergeSort(listTwo);

            //enviamos nuestra lista al metodo Merge
            return Merge(sortedListOne, sortedListTwo); ;
        }

        public List<int> Merge(List<int> one, List<int> two)
        {
            //creamos una lista donde almacenaremos la lista actualizada
            List<int> sortedList = new List<int>();

            //imprimimos los valores de la lista que se van a comparar
            Console.WriteLine("-----------------------------------------------");
            printList(one);
            Console.Write("------> ");
            printList(two);
            Console.WriteLine("\n");

            //creamos nuestra lista donde se comparara cada y uno de los valores hasta que una de las dos listas
            //quede vacia
            while (one.Count != 0 && two.Count != 0)
            {
                //comparamos el primer resultado de ambas lista, se añadira a la nueva lista el valor mas bajo
                //y se eliminara de la lista para dar un nuevo primer resultado
                if (one[0] > two[0])
                {
                    sortedList.Add(two[0]);
                    two.RemoveAt(0);
                }
                else
                {
                    sortedList.Add(one[0]);
                    one.RemoveAt(0);
                }
            }

            //añadiremos los resultados restantes en caso de que haya sobrado alguno
            while (two.Count != 0)
            {
                sortedList.Add(two[0]);
                two.RemoveAt(0);
            }
            while (one.Count != 0)
            {
                sortedList.Add(one[0]);
                one.RemoveAt(0);
            }

            //imprimimos nuestros resultados
            Console.WriteLine("sorted");
            printList(sortedList);
            Console.WriteLine("\n \n");

            return sortedList;
        }
    }
}
