using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestAndSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 3, 6, 2, 10, 1 };
            var output = FindSmallest(input, out int smallestValue);

            Console.WriteLine($"Smallest item value: '{smallestValue}'; at index: '{output}'");

            //sorting / orderby
            Console.WriteLine("Array not sorted:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"- Elemento '{i}': '{input[i]}'");
            }

            int[] outputSorted = SelectionSort(input);

            Console.WriteLine("Array sorted:");
            for (int i = 0; i < outputSorted.Length; i++)
            {
                Console.WriteLine($"- Elemento '{i}': '{outputSorted[i]}'");
            }

            Console.ReadLine();
        }

        private static int[] SelectionSort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int cycles = arr.Length;

            for (int i = 0; i < cycles; i++)
            {
                int smallestIndex = FindSmallest(arr, out int smallestValue);
                //Array.Copy(newArr, , newArr, , arr.Length);
                newArr[i] = smallestValue;
                //ora devo rimuovere l'elemento estratto come il più piccolo
                arr = arr.Except(new int[] { smallestValue }).ToArray();
            }

            return newArr;
        }

        static int FindSmallest(int[] arr, out int smallestValue)
        {
            int smallestIndex = 0;
            smallestValue = arr[smallestIndex];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestValue)
                {
                    smallestIndex = i;
                    smallestValue = arr[smallestIndex];
                }
            }

            return smallestIndex;
        }
    }
}