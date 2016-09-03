using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStack
{
    public class StringStack
    {
        private string[] _stringStack;

        public StringStack()
        {
            _stringStack = new string[1];
        }


        public void Push(string newString)
        {
            Array.Resize(ref _stringStack, _stringStack.Length + 1);
            _stringStack[_stringStack.Length - 1] = newString;
        }


        public string Pop()
        {
            string popedString = _stringStack[0];
            for (int i = 1; i < _stringStack.Length; i++)
            {
                _stringStack[i - 1] = _stringStack[i];
            }

            Array.Resize(ref _stringStack, _stringStack.Length -1);
            return popedString;
        }



        public string Peak()
        {
            return _stringStack[0];
        }


        public string[] ToArray()
        {
            return _stringStack;
        }


        public void Clear()
        {
            Array.Clear(_stringStack, 0, _stringStack.Length);
        }


        public override bool Equals(object comparableObject)
        {
            return _stringStack.Equals(comparableObject);
        }
    }
}
