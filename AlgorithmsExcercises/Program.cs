using AlgorithmsExcercises.ordenamiento;
using AlgorithmsExcercises.Recursividad;
using System;
using System.Collections.Generic;


namespace AlgorithmsExcercises
{
    internal class Program
    {


        static void Main(string[] args)
        {
            sorts s = new sorts();
            MergeSorts m = new MergeSorts();
            cocktailSort c = new cocktailSort();
            
            
            int[] numbers = { 9, 5, 25, 8, 2, 12, 32, 1, 10, 4, 3, 9};
            List<int> listNumbers = new List<int>();
            List<int> listNumbersSorted = new List<int>();
            listNumbers.AddRange(numbers);


           
            //quickSorts q = new quickSorts(listNumbers);

            List<char> list = new List<char>();
            //nuestro string que compararemos si es un palindromo
            //string words = "anita lava la tina";
            //list = p.stringToList(words);

            //p.isPalindromo(p.palindromoExcercise(list));

            //listNumbersSorted = q.quickSort(0, listNumbers.Count - 1);
            //Console.WriteLine("\n \n \n");

            //listNumbersSorted = c.cocktailSortExcercise(listNumbers, 0, listNumbers.Count);

            //foreach (var item in listNumbersSorted)
            //{
            //    Console.Write(item + ", ");
            //}

            //foreach (var item in numbers)
            //{
            //    Console.Write(item.ToString() + ", ");
            //}

            //Console.WriteLine("\n \n");

            //s.heapSort(listNumbers);

            Console.ReadKey();
        }
    }
}
