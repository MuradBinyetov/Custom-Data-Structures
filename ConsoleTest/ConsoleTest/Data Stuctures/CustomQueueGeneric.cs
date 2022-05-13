using ConsoleTest.Exceptions;
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

        public void Clear()
        {
            if (top == 0)
            {
                throw new QueueEmptyException("Queue is empty");
            }
            top = 0;
        }

        public T[] ToArray()
        {
            T[] newArr = new T[_values.Length];
            Array.Copy(_values, newArr, _values.Length);
            return newArr;
        }

        public bool Contains(T data)
        {
            if (top >= 1)
            {
                for (int i = 0; i < top; i++)
                {
                    if (_values[i].Equals(data))
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }

        public void GetEnumerator()
        {
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(_values[i]);
            }
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
