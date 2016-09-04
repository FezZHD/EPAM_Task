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
            string temp = stack.Pop();
            stack.Push("Hello");            
            stack.Push("It's me");
            stack.Push("!!!");
            stack.Push("kek");
            Console.WriteLine("{0}",stack.Length);
            Console.WriteLine("{0}",stack.Peak());
            string[] arrayStrings = stack.ToArray();
            foreach (string str in arrayStrings)
            {
                Console.WriteLine(str);                
            }
            Console.WriteLine("{0}",stack.Pop());
            Console.WriteLine("{0}",stack.Length);
            stack.Clear();
            Console.WriteLine("{0}", stack.Length);
            Console.ReadLine();
        }
    }
}
