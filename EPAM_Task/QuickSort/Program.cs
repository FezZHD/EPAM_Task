using System;
using System.Collections.Generic;
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
            int capacity = Convert.ToInt32(Console.ReadLine());
            int[] randomArray = GetRandomArray(capacity);
        }

        private static int[] GetRandomArray(int arrayCapacity)
        {
            Random randomObject = new Random(); 
            int[] resultArray = new int[arrayCapacity];
            for (int i = 0; i < arrayCapacity; i++)
            {
                resultArray[i] = randomObject.Next(-2000, 2000);
            }
            return resultArray;
        }
    }
}
