using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Exceptions
{
    public class StackEmpty : Exception
    {
        private string message;
        private Exception innerException;
        public StackEmpty(string message) 
                : base(message)
        {
        }

        public StackEmpty(string message, Exception innerException)
            : base(message, innerException)
        {
            this.message = message;
            this.innerException = innerException;
        }
    }
}
