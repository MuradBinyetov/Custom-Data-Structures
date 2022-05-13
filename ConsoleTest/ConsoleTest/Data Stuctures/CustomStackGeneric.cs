using ConsoleTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Data_Stuctures
{
    class CustomStackGeneric<T>
    {
        private T[] _values;
        private int top = 0;

        public CustomStackGeneric()
        {
            _values = new T[0];

        } 
        public int Count => _values.Length;
        public void Push(T data)
        {
            if (top >= Count)
            {
                _values = StackResize(_values);
            }
            _values[top] = data;
            top++;
        }

        public T Pop()
        {
            if (top == 0)
            {
                throw new StackEmptyException("Stack is empty"); // My Exception Class
            }
            return _values[--top];
        }

        public T Peek()
        {
            if (top == 0)
            {
                throw new StackEmptyException("Stack is empty"); // My Exception Class
            }
            else
            {
                return _values[top-1];
            }
        }

        public object[] ToArray()
        {
            object[] newArr = new object[_values.Length];
            Array.Copy(_values, newArr, _values.Length);
            return newArr;
        }

        public void Clear()
        {
            if (top == 0)
            {
                throw new StackEmptyException("Stack is empty"); // My Exception Class
            }
            else
            {
                top = 0;
            }
        }

        public void GetEnumerator()
        {
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(_values[i]);
            }
        }

        private T[] StackResize(T[] values)
        {
            T[] newValues = new T[0];
            if (values.Length == 0)
            {
                newValues = new T[4];
            }
            else
            {
                newValues = new T[values.Length * 2];
            }

            Array.Copy(values, newValues, values.Length);
            return newValues;
        }

    }
}
