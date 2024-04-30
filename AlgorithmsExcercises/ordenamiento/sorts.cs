using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises.ordenamiento
{
    internal class sorts
    {
        //nuestra lista de numeros a ordenar
        int[] numbers = { 9, 5, 25, 8, 2, 9, 32, 1, 10, 4, 3, 12 };

        //metodo para imprimir
        public void printList(int[] numberlist)
        {
            foreach (int n in numberlist)
                {
                    Console.Write(n.ToString() + ", ");
                }
                Console.WriteLine();
        }
        public void SelectionSort()
        {
            //en este algoritmo se encontrara el valor mas pequeño dentro del arreglo y se intercambiara con el que esta en la primera
            //posicion (que en estos casos la primera posicion seria el index de nuestra i)

            //la variable auxiliar que utilizaremos para ayudar al cambio de valores
            int aux;

            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                //nuestro indice del numero mas bajo actual en cada ciclo
                int numberMinInd = i;

                //nuestro foreach para imprimir la lista
                printList(numbers);

                //salto de linea
                Console.WriteLine();

                //for para verificar cual es el index con el valor mas bajo
                for (int j = i + 1; j < (numbers.Length); j++)
                {
                    //comparamos si el numero mas bajo actual es mayor que el numero en el index de J actual
                    if (numbers[numberMinInd] > numbers[j])
                    {
                        //cambiamos el index del nuevo numero mas bajo
                        numberMinInd = j;
                    }
                }

                //si el numero del index actual es distinto al index del numero mas bajo, se hara el cambio del lugar de los valores
                if (i != numberMinInd)
                {
                    aux = numbers[i];
                    numbers[i] = numbers[numberMinInd];
                    numbers[numberMinInd] = aux;
                }
                
            }

            Console.ReadLine();
        }

        public void BubbleSort()
        {
            //la variable auxiliar que utilizaremos para ayudar al cambio de valores
            int aux;

            for (int i = 1; i < (numbers.Length); i++)
            {
                //nuestro foreach para imprimir la lista
                printList(numbers);

                //hacemos un for anidado para hacer la comparacion de cada valor
                for (int j = 0; j < numbers.Length - i; j++)
                {
                    //hacemos la comparacion si la casilla actual es mayor que la siguiente casilla
                    if (numbers[j] > numbers[j + 1])
                    {
                        //hacemos el cambio del valor
                        aux = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = aux;
                    }
                }
                    
            }
            Console.ReadLine();
        }

        public void insertionSort()
        {
            //la variable auxiliar que utilizaremos para ayudar al cambio de valores
            int aux;

            for (int i = 1; i < numbers.Length; i++)
            {
                int actualIndex = i;

                //nuestro foreach para imprimir la lista
                printList(numbers);

                //comparamos si el numero actual es menor que el numero a nuestra izquierda
                while (actualIndex > 0 && numbers[actualIndex] < numbers[actualIndex - 1])
                {
                    //hacemos el cambio de los valores hasta que el numero actual no sea menor que al
                    //de la izquierda
                    aux = numbers[actualIndex];
                    numbers[actualIndex] = numbers[actualIndex - 1];
                    numbers[actualIndex - 1] = aux;

                    actualIndex--;
                }
            }
            //nuestro foreach para imprimir la lista(como se acaba el for antes
            //de poder imprimir la ultima linea la ponemos aqui nuevamente)
            printList(numbers);

            Console.WriteLine();
            Console.ReadLine();
        }

        

        public void heapSort()
        {

        }

        public void countingSort()
        {

        }

        public void RadixSort()
        {

        }

        public void bucketSort()
        {

        }
    }
}
