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
            CustomStack stack = new CustomStack();
            stack.Push(2);
            stack.Push(23);
            stack.Push(21);
            stack.Push(276);
            stack.Push(3452);
            var a =stack.Contains(3);
            var b = stack.Contains(276);
        }  
    }
}
