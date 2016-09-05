﻿using System;


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
            for (int i = _stringStack.Length - 1 ; i > 0; i--)
            {
                _stringStack[i] = _stringStack[i - 1];
            }
            _stringStack[0] = newString;
        }


        public string Pop()
        {
            try
            {
                string popedString = _stringStack[0];
                for (int i = 1; i < _stringStack.Length; i++)
                {
                    _stringStack[i - 1] = _stringStack[i];
                }

                Array.Resize(ref _stringStack, _stringStack.Length -1);
                return popedString;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }     
        }



        public string Peak()
        {
            try
            {
                return _stringStack[0];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
           
        }


        public string[] ToArray()
        {
            return (string[])_stringStack.Clone();
        }


        public void Clear()
        {
            Array.Clear(_stringStack, 0, _stringStack.Length);
            Array.Resize(ref _stringStack, 0);
        }
    }
}
