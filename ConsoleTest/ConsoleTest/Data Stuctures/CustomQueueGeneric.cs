using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Data_Stuctures
{
    class CustomQueueGeneric<T>
    {
        private T[] _values;
        private int top;
        public CustomQueueGeneric()
        {
            _values = new T[0];
        }
        public int Count => _values.Length;
    }
}
