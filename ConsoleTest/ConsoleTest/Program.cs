using ConsoleTest.Data_Stuctures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    { 
        static void Main(string[] args)
        {
            Stack st = new Stack(); 
            CustomStackGeneric<int> stack = new CustomStackGeneric<int>(); 
            stack.Push(3); 
            stack.Pop();  
            stack.Push(5); 
            stack.GetEnumerator();
            var a = stack.Pop();
            stack.Push(8);
        }  
    }
}
