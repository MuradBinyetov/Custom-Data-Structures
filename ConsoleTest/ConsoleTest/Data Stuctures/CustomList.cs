using CustomDataStructures.Exceptions;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CustomDataStructures.Data_Stuctures
{
    class CustomList<T> 
    {
        private T[] _values;
        private int top;

        public CustomList()
        {
            _values = new T[0];
        }

        public int Count => _values.Length;

        public void Add(T data)
        {
            if (top >= Count)
            {
                _values = ResizeList(_values);
            }

            _values[top] = data;
            top++;
        }

        public void Clear()
        {
            if (top == 0)
            {
                throw new ListEmptyException("List is empty");
            }
            else
            {
                top = 0;
            }
        }

        public T[] ToArray()
        {
            T[] resp = new T[_values.Length];
            Array.Copy(_values, resp, _values.Length);
            return resp;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                if(top >= Count)
                {
                    _values = ResizeList(_values);
                }
                _values[top] = item;
                top++;
            }
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < top; i++)
            {
                if(_values[i].Equals(data))
                {
                    return true;
                }
                else
                {
                    continue;
                } 
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < top; i++)
            {
                if(_values[i].Equals(item))
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }

        
        //<summary>
        //  Add item to specified index
        //</summary>
        public void Insert(int index,T item) //[2,3,4,5] --> [2,3,10,4,5]
        {
            if (top >= Count)
            {
                _values = ResizeList(_values);
            }

            T[] newArr = new T[_values.Length]; 
            Array.Copy(_values, newArr,index);
            newArr[index] = item;
            Array.Copy(_values, index, newArr, index + 1, top - index); 
        }

        //<summary>
        //  Add many items to specified index
        //</summary>
        public T[] InsertRange(int index, IEnumerable<T> collection) //[2,3,4,5] --> [2,3,22,33,44,4,5]
        {
            if (top >= Count)
            {
                _values = ResizeList(_values);
            }
            T[] newArr = new T[_values.Length];
            int temp = index;
            Array.Copy(_values, newArr, index);

            foreach (var item in collection)
            {  
                if(top >= newArr.Length)
                {
                    newArr = ResizeList(newArr);
                }
                newArr[index] = item;
                
                index++;
                top++;
            }
            Array.Copy(_values, temp, newArr, index, top-index);
            return newArr;
        }

        //<summary>
        //  Remove item from specified index
        //</summary>
        public void RemoveAt(int index)
        {

        }


        private T[] ResizeList(T[] arr)
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
