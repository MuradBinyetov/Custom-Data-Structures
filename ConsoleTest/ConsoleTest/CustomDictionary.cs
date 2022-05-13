using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class CustomDictionary<TKey, UValue> : IEnumerable<KeyValuePair<TKey, UValue>>
    {
        private LinkedList<KeyValuePair<TKey, UValue>>[] _values;
        private int capacity;

        public CustomDictionary()
        {
            _values = new LinkedList<KeyValuePair<TKey, UValue>>[15];    
        }

        public int Count => _values.Length;

        public void Add(TKey key,UValue value)
        { 
            var hash = GetHashValue(key);
            if(_values[hash] == null)
            {
                _values[hash] = new LinkedList<KeyValuePair<TKey, UValue>>();
            }
            var keyPresent = _values[hash].Any(p => p.Key.Equals(key));
            if (keyPresent)
            {
                throw new Exception("Duplicate key has been found");
            }

            var newValue = new KeyValuePair<TKey, UValue>(key, value);
            _values[hash].AddLast(newValue);

            capacity++;
            if (Count <= capacity)
            {
                ResizeCollection();
            }
        }

        public bool ContainsKey(TKey key)
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

        public UValue GetValue(TKey key)
        {
            var hash = GetHashValue(key);
            if(_values[hash] == null)
            {
                return default;
            }
            else
            {
                return _values[hash].First(p => p.Key.Equals(key)).Value;
            }
        }


        private void ResizeCollection()
        {
            throw new NotImplementedException();
        }

        private int GetHashValue(TKey key)
        { 
            return (Math.Abs(key.GetHashCode())) % _values.Length;
        }

        public IEnumerator<KeyValuePair<TKey, UValue>> GetEnumerator()
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
