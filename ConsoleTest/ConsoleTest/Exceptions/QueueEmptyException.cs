using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Exceptions
{
    class QueueEmptyException : Exception
    {
        public QueueEmptyException(string message) : base(message)
        { 
        }
    }
}
