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
            CustomStack stack = new CustomStack(); 
            stack.Push(3); 
            stack.Pop();  
            stack.Push(5);
            stack.Push("Hello World");
            stack.Push("Bye World");
            stack.Push("Hello2 World"); 
            stack.GetEnumerator();
            var a = stack.Pop();
            stack.Push(8);
        }  
    }
}
