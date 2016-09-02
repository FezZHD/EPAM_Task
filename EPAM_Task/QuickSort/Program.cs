using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capacity of your int array?");
            int capacity;
            try
            {
                capacity = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please, restart programm");
                return;
            }
            int[] randomArray = GetRandomArray(capacity);
            PrintArray(randomArray, "Your array is:\n");
            Console.ReadLine();
        }
        

        private static int[] GetRandomArray(int arrayCapacity)
        {
            const int maxValue = 2000;
            const int minValue = -2000;
            Random randomObject = new Random(); 
            int[] resultArray = new int[arrayCapacity];
            for (int i = 0; i < arrayCapacity; i++)
            {
                resultArray[i] = randomObject.Next(minValue, maxValue);
            }
            return resultArray;
        }


        private static void PrintArray(int[] array, string text = null)
        {
            Console.WriteLine(text);
            foreach (int item in array)
            {
                Console.Write("{0} ", item);
            }
        }

    }
}
