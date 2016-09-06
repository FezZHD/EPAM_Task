using System;


namespace StringStack
{
    public class StringStack
    {
        public int Length {
            get
            {
                return _stringStack.Length;
            }
        }

        private string[] _stringStack;

        public StringStack()
        {
            _stringStack = new string[0];
        }


        public void Push(string newString)
        {
            Array.Resize(ref _stringStack, _stringStack.Length + 1);
            _stringStack[Length - 1] = newString;
        }


        public string Pop()
        {
            try
            {
                string popedString = _stringStack[Length - 1];
                Array.Resize(ref _stringStack, _stringStack.Length -1);
                return popedString;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }     
        }



        public string Peek()
        {
            try
            {
                return _stringStack[Length - 1];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
           
        }


        public string[] ToArray()
        {
            string[] returnArray = (string[]) _stringStack.Clone();
            Array.Reverse(returnArray);
            return returnArray;
        }


        public void Clear()
        {
            Array.Clear(_stringStack, 0, _stringStack.Length);
            Array.Resize(ref _stringStack, 0);
        }
    }
}
