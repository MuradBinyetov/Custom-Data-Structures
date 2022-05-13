using ConsoleTest.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class CustomStack  
    {
        private object[] _values; 
        private int top = 0;

        public CustomStack()
        {
            _values = new object[0];
            
        }
        public int Count => _values.Length;
        public void Push(object data)
        {
            if(top >= Count)
            {
               _values = StackResize(_values);
            }
            _values[top] = data;
            top++;
        }

        public object Pop()
        {
            if (top == 0)
            {
                throw new StackEmptyException("Stack is empty"); // My Exception Class
            }
            return _values[--top];
        }

        public object Peek()
        {
            if(top == 0)
            {
                throw new StackEmptyException("Stack is empty"); // My Exception Class
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
                throw new StackEmptyException("Stack is empty"); // My Exception Class
            }
            else
            {
                top = 0;
            }
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

        public object[] ToArray()
        {
            object[] newArr = new object[_values.Length];
            Array.Copy(_values, newArr, _values.Length);
            return newArr;
        }

        public void GetEnumerator()
        {
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(_values[i]);
            }
        }

        private object[] StackResize(object[] values)
        {
            object[] newValues = new object[0];
            if (values.Length == 0)
            {
                newValues = new object[4];
            }
            else
            {
                newValues = new object[values.Length * 2];
            }
            
            Array.Copy(values, newValues,values.Length);
            return newValues;
        } 
    }
}
