using ConsoleTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Data_Stuctures
{
    class CustomQueue
    {
        private object[] _values;
        private int top;
        public CustomQueue()
        {
            _values = new object[0];
        }
        public int Count => _values.Length;

        public void Enqueue(object data)
        {
            if(top >= Count)
            {
                _values = QueueResize(_values);
            }

            _values[top] = data;
            top++;
        }

        public object Dequeue()
        {
            if(top == 0)
            {
                throw new QueueEmptyException("Queue is empty");
            }
            else
            {
                return _values[--top];
            }
        }

        public object Peek()
        {
            if(top == 0)
            {
                throw new QueueEmptyException("Queue is empty");
            }
            else
            {
                return _values[top-1];
            }
        }

        public void Clear()
        {
            if (top == 0)
            {
                throw new QueueEmptyException("Queue is empty");
            }
            else
            {
                top = 0;
            }
        } 
        public object[] ToArray()
        {
            object[] newArr = new object[_values.Length];
            Array.Copy(_values, newArr, _values.Length);
            return newArr;
        }

        public bool Contains(object data)
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

        private object[] QueueResize(object[] arr)
        {
            object[] newArr = new object[0];
            if (arr.Length == 0)
            {
                newArr = new object[4];
            }
            else
            {
                newArr = new object[arr.Length * 2];
            }

            Array.Copy(arr, newArr, arr.Length);
            return newArr;
        }
    }
}
