using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Exceptions
{
    class DictionaryDuplicateKey : Exception
    {
        private string message;
        private Exception innerException;
        public DictionaryDuplicateKey(string message)
                :base()
        { 
        }

        public DictionaryDuplicateKey(string message,Exception innerException)
                :base(message, innerException)
        {
            this.message = message;
            this.innerException = innerException;
        }
    }
}
