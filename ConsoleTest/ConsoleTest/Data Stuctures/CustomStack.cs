﻿using ConsoleTest.Exceptions;
using System;
using System.Collections.Generic;
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
                throw new StackEmpty("Stack is empty"); // My Exception Class
            }
            return _values[--top];
        }

        public object Peek()
        {
            if(top == 0)
            {
                throw new StackEmpty("Stack is empty"); // My Exception Class
            }
            else
            {
                return _values[top];
            }
        }

        public void Clear()
        {
            if (top == 0)
            {
                throw new StackEmpty("Stack is empty"); // My Exception Class
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