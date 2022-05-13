using ConsoleTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    class CustomLinkedList
    {

        int iCount = 1;
        int iCurrent = 0;
        Node nCurrent;

        public int Count
        {
            get
            {
                return iCount;
            }
        }

        public Node CurrentNode
        {
            get
            {
                return nCurrent;
            }
        }

        public int CurrentNodeIndex
        {
            get
            {
                return iCurrent;
            }
        }

        public CustomLinkedList(object obj)
        {
            nCurrent = new Node(null, null, obj);
            nCurrent.Next = null;
            nCurrent.Previous = null;
        }

        public void AddNode(object obj)
        {
            if (nCurrent.Next == null)
            {
                nCurrent = nCurrent.Next = new Node(nCurrent, null, obj);
            }
            else
            {
                nCurrent = nCurrent.Next = new Node(nCurrent, nCurrent.Next, obj);
            }
            iCount++;
            iCurrent++;
        }

        public Node ToNext()
        {
            // Checks whether the Next Node is null
            // if so it throws an exception.
            // You can also do nothing but I choos for this.
            if (nCurrent.Next == null)
            {
                throw new LinkedListNodeException("There is no next node!");
            }
            else // If everything is OK
            {
                nCurrent = nCurrent.Next;
                iCurrent++;
            }
            return nCurrent;
        }

        public Node ToPrevious()
        {
            // Look at ToNext();
            if (nCurrent.Previous == null)
            {
                throw new LinkedListNodeException("There is no previous node!");
            }
            else
            {
                nCurrent = nCurrent.Previous;
                iCurrent--;
            }
            return nCurrent;
        }

        public Node GoTo(int index)
        {
            int i = 0; 
            while (i < index)
            {
                ToNext();
            }

            if (iCurrent < index)
            {
               return ToNext();
            }
            else if (iCurrent > index)
            {
               return ToPrevious();
            }
            return default;
        }
    }

    class Node
    {
        protected Node nPrevious;
        protected Node nNext;
        protected object Object;

        public object Value
        {
            get
            {
                return Object;
            }
            set
            {
                Object = value;
            }
        }

        public Node Previous
        {
            get
            {
                return nPrevious;
            }
            set
            {
                nPrevious = value;
            }
        }

        public Node Next
        {
            get
            {
                return nNext;
            }
            set
            {
                nNext = value;
            }
        } 

        public Node(Node PrevNode, Node NextNode, object obj)
        {
            nPrevious = PrevNode;
            nNext = NextNode;
            Object = obj;
        }
    }
}
