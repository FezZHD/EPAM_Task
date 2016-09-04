using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStack
{
    class Program
    {
        static void Main(string[] args)
        {
            StringStack stack = new StringStack();
            stack.Push("Hello");            
            stack.Push("It's me");
            Console.WriteLine("{0}",stack.Length);
            Console.WriteLine("{0}",stack.Peak());
            string[] arrayStrings = stack.ToArray();
            foreach (string str in arrayStrings)
            {
                Console.WriteLine(str);                
            }
            Console.WriteLine("{0}",stack.Pop());
            Console.WriteLine("{0}",stack.Length);
            Console.WriteLine("{0}",stack.ToString());
            Console.ReadLine();
        }
    }
}
