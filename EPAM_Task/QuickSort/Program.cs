using System;

namespace QuickSort
{
    class Program
    {
        static void Main()
        {        
            Console.WriteLine("Capacity of your int array?");
            uint capacity = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {  
                try
                {
                    capacity = Convert.ToUInt32(Console.ReadLine());
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    ExceptionActivity();
                }
                catch (OverflowException)
                {
                    ExceptionActivity();
                }
            }
           
            int[] randomArray = GetRandomArray(capacity);
            PrintArray(randomArray, "Your array is:\n");
            QuickSort(ref randomArray, 0, (int) capacity - 1);
            PrintArray(randomArray, "\nYour sorted array is:\n");
            double timeMark = capacity * Math.Log(capacity, 2);
            Console.WriteLine("\nAverage algorithm time is O({0})", timeMark);
            Console.ReadLine();
        }
        

        private static int[] GetRandomArray(uint arrayCapacity)
        {
            const int MAX_VALUE = 2000;
            const int MIN_VALUE = -2000;
            Random randomObject = new Random(); 
            int[] resultArray = new int[arrayCapacity];
            for (int i = 0; i < arrayCapacity; i++)
            {
                resultArray[i] = randomObject.Next(MIN_VALUE, MAX_VALUE);
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


        private static void ExceptionActivity()
        {
            Console.WriteLine("Error, please, repeat your input");
        }


        private static void QuickSort(ref int[] array, int start, int end)
        {
            int startIndex = start;
            int endIndex = end;

            int middleElement = array[(startIndex + endIndex) >> 1];

            while (startIndex <= endIndex)
            {

                while (array[startIndex] < middleElement)
                    startIndex++;

                while (array[endIndex] > middleElement)
                    endIndex--;

                if (startIndex <= endIndex) 
                    Swap(ref array, ref startIndex, ref endIndex);      
            }

            if (start < endIndex)
                QuickSort(ref array, start, endIndex);
            
 
            if (startIndex < end)
                QuickSort(ref array, startIndex, end);
        }


        private static void Swap(ref int[] array, ref int firstPartIndex, ref int secondPartIndex)
        {
            int temp = array[firstPartIndex];
            array[firstPartIndex] = array[secondPartIndex];
            array[secondPartIndex] = temp;
            firstPartIndex++;
            secondPartIndex--;
        }
    }
}
