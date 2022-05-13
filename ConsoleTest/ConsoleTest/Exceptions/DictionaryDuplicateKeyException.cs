using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Exceptions
{
    class DictionaryDuplicateKeyException : Exception
    {
        private string message;
        private Exception innerException;
        public DictionaryDuplicateKeyException(string message)
                :base()
        { 
        }

        public DictionaryDuplicateKeyException(string message,Exception innerException)
                :base(message, innerException)
        {
            this.message = message;
            this.innerException = innerException;
        }
    }
}
