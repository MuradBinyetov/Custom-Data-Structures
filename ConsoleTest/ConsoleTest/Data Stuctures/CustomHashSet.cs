using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class CustomHashSet<T> : IEnumerable<T>
    {
        private LinkedList<T>[] _values;
        private int capacity;

        public CustomHashSet()
        {
            _values = new LinkedList<T>[15];
            capacity = _values.Length;
        }

        public bool Add(T data)
        {
            int hash = GetHashValue(data);
            if(_values[hash] == null)
            {
                _values[hash] = new LinkedList<T>(); 
            }
            bool isPresent = _values[hash].Any(p=>p.Equals(data));
            if (isPresent)
            {
                Console.WriteLine("This data is already exist");
                return false;
            }

            _values[hash].AddLast(data); 
            capacity++;
            return true;
        }

        public bool Contains(T data)
        {
            int hash = GetHashValue(data);
            if(_values[hash] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetHashValue(T data)
        {
            return Math.Abs(data.GetHashCode()) % 15;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (from collections in _values
                    where collections != null
                    from item in collections
                    select item).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
