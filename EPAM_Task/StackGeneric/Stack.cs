using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGeneric
{
    class Stack<T> where T: class
    {
        private T[] _stackArray;

        public int Length{
            get
            {
                return _stackArray.Length;
            }
        }


        public Stack()
        {
           _stackArray = new T[0];
        }


        public void Push(T newElement)
        {
            Array.Resize(ref _stackArray, _stackArray.Length + 1);
            _stackArray[Length - 1] = newElement;
        }


        public T Pop()
        {
            T popedElement;
            try
            {
                popedElement = _stackArray[Length - 1];
                Array.Resize(ref _stackArray, _stackArray.Length - 1);
                return popedElement;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }          
        }


        public T Peek()
        {
            try
            {
                return _stackArray[Length - 1];
            }
            catch (IndexOutOfRangeException)
            {

                return null;
            }
           
        }


        public T[] ToArray()
        {
            T[] returnArray = (T[]) _stackArray.Clone();
            Array.Reverse(returnArray);
            return returnArray;
        }


        public void Clear()
        {
            Array.Clear(_stackArray, 0, _stackArray.Length);
            Array.Resize(ref _stackArray, 0);
        }
    }
}
