using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class CustomHashTable : IEnumerable
    {
        private LinkedList<KeyValuePair<object,object>>[] _values;
        private int capacity;


        public CustomHashTable()
        {
            _values = new LinkedList<KeyValuePair<object, object>>[15];
        }

        public int Count => _values.Length;

        public void Add(object key,object value)
        {
            int hash = GetHashValue(key);

            if(_values[hash] == null)
            {
                _values[hash] = new LinkedList<KeyValuePair<object, object>>();
            }
            var keyPresent = _values[hash].Any(p => p.Key.Equals(key));
            if (keyPresent)
            {
                throw new Exception("Duplicate key has been found");
            }

            var newValue = new KeyValuePair<object,object>(key, value);
            _values[hash].AddLast(newValue);
            capacity++;
        }

        public bool ContainsKey(object key)
        {
            var hash = GetHashValue(key);
            if(_values[hash] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object GetValue(object key)
        {
            var hash = GetHashValue(key);
            if(_values[hash] == null)
            {
                return default;
            }
            else
            {
               return _values[hash].First(p=>p.Key.Equals(key)).Value;
            }
        }

        private int GetHashValue(object key)
        {
            return Math.Abs(key.GetHashCode()) % 15; // if key or key.GetHashCode < 0 return index out of bound exception;
        }

        public IEnumerator GetEnumerator()
        {
            return (from collections in _values
                    where collections != null
                    from item in collections
                    select item).GetEnumerator();
        }
    }
}
