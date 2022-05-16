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
            lt.Add(11);
            lt.Add(12);
            lt.Add(13);
            lt.Add(14);
            lt.Add(15);
            lt.Add(16);
            lt.Add(17);
            lt.Reverse(3,7);
        }  
    }
}
