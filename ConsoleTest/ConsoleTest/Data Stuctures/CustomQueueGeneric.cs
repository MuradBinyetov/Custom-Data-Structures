using ConsoleTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Data_Stuctures
{
    class CustomQueueGeneric<T> where T : class
    {
        private T[] _values;
        private int top;
        public CustomQueueGeneric()
        {
            _values = new T[0];
        }
        public int Count => _values.Length;

        public void Enqueue(T data)
        {
            if(top >= Count)
            {
                _values = ResizeQueue(_values);
            }
            _values[top] = data;
            top++;
        }

        public T Dequeue()
        {
            if(top == 0)
            {
                throw new QueueEmptyException("Queue is empty");
            }
            return _values[--top];
        }

        public T Peek()
        {
            return _values[top-1];
        }

        private T[] ResizeQueue(T[] arr)
        {
            T[] newArr = new T[0];
            if (arr.Length == 0)
            {
                newArr = new T[4];
            }
            else
            {
                newArr = new T[arr.Length * 2];
            }

            Array.Copy(arr, newArr, arr.Length);
            return newArr;
        }
    }
}
