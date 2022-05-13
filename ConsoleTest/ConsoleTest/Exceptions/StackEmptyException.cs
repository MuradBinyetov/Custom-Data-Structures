using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Exceptions
{
    public class StackEmptyException : Exception
    {
        private string message;
        private Exception innerException;
        public StackEmptyException(string message) 
                : base(message)
        {
        }

        public StackEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
            this.message = message;
            this.innerException = innerException;
        }
    }
}
