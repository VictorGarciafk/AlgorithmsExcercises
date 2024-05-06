using System;
using System.Collections.Generic;

namespace AlgorithmsExcercises.Recursividad
{
    internal class quickSorts
    {
        List<int> numberList = new List<int>();
        public quickSorts(List<int> number) { 
        
            this.numberList = number;
        }

        //metodo para imprimir la lista de numeros
        public void printList(List<int> numberlist, int ini, int fi)
        {
            for (int i = ini; i <= fi ; i++)
            {
                Console.Write(numberList[i] + ", ");
            }
        }

        //metodo para hacer el cambio de los numeros en la lista
        public void swap(int i, int pivotIndex)
        {
            int aux;
            aux = numberList[pivotIndex];
            numberList[pivotIndex] = numberList[i];
            numberList[i] = aux;
        }

        //en este metodo iremos definiendo nuestro "pivot" por cada interaccion que haga
        public List<int> quickSort(int inicio, int final)
        {
            int pivot;
            //si tenemos que el valor del inicio es mayor o igual que el del final regresamos el valor
            //usamos este if para darle un final cuando llegue a los ultimos datos a ordenar y
            //evitar que se forme un ciclo
            if (inicio >= final)
            {
                return numberList;
            }

            //llamamos al metodo que nos regresara el pivot actual, ademas de ordenar los resultados
            pivot = orderAndGetPivot(inicio, final);

            //llamaremos a esta misma clase para que vaya interactuando con el nuevo valor del pivot
            quickSort(inicio, pivot - 1);
            quickSort(pivot + 1, final);

            //al final retornamos nuestra lista
            return numberList;
        }

        //esta clase tiene el proposito de ordenar los numeros menores al numero de la lista con el
        //indice equivalente al pivot, ademas de regresar la nueva posicion del pivot
        public int orderAndGetPivot(int inicio, int final)
        {
            int pivotIndex = inicio;
            //para este caso determinaremos que nuestro pivot sera el ultimo numero de la lista
            int pivot = final;

            //imprimiremos la lista actual para compararla de como queda con la lista ya modificada
            printList(numberList, inicio, final);
            Console.WriteLine("\n \n \n");

            for (int i = inicio; i < final; i++)
            {
                //compararemos cada uno de los valores si son mayores o menores que el pivot actual
                if (numberList[i] < numberList[pivot])
                {
                    //si el valor es menor que el pivot cambiaremos de lugar
                    swap(i, pivotIndex);
                    //se aumentara el valor del pivot para determinar el nuevo lugar del ultimo
                    //valor de la lista
                    pivotIndex++;

                    //imprimimos el proceso de como va cambiando los valores en la lista
                    printList(numberList, inicio, final);
                    Console.WriteLine("\n \n \n");
                }
            }
            //una vez terminado el proceso cambiamos el ultimo valor de la lista con el del indice
            //asi para dejar los valores mas grandes a la derecha y los valores mas pequeños a la
            //izquierda
            swap(pivot, pivotIndex);

            //observamos como quedaron los cambios al final
            printList(numberList, inicio, final);
            Console.WriteLine("\n \n \n \n \n \n");

            //retornamos el index del pivot actual
            return pivotIndex;
        }

        
    }
}
