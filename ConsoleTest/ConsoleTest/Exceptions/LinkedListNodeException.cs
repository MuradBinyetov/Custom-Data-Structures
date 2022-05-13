using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest.Exceptions
{
    class LinkedListNodeException : Exception
    {
        public LinkedListNodeException(string message)
                :base(message)
        {
        }
    }
}
