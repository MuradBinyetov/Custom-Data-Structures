using ConsoleTest.Data_Stuctures;
using CustomDataStructures.Data_Stuctures;
using System;
using System.Buffers;
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
            List<int> list = new List<int>();     
            CustomList<int> lt = new CustomList<int>();
            lt.Add(2);
            lt.Add(3); 
            lt.Add(4);   
            lt.Add(5);   
            lt.Add(6);
            lt.Add(7);
            lt.Add(8);
            lt.Add(9);
            lt.Add(10);
            lt.Reverse();
        }  
    }
}
