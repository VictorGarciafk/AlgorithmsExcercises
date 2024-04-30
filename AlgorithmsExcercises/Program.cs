using AlgorithmsExcercises.ordenamiento;
using AlgorithmsExcercises.Recursividad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sorts s = new sorts();
            MergeSorts m = new MergeSorts();
            
            int[] numbers = { 9, 5, 25, 8, 2, 9, 32, 1, 10, 4, 3, 12};
            List<int> listNumbers = new List<int>();
            listNumbers.AddRange(numbers);

            //List<int> solved = m.MergeSort(listNumbers);

            //s.insertionSort();

            Console.ReadKey();
        }
    }
}
