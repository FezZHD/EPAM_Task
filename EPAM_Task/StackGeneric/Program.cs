using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hi");
            stringStack.Push("How are u?");
            string tempString = stringStack.Peek();
            Console.WriteLine(stringStack.Pop());
            stringStack.Push("Hello, again");
            string[] stringArray = stringStack.ToArray();
            Console.ReadLine();
        }
    }
}
