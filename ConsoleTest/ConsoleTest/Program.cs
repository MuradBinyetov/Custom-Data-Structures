using ConsoleTest.Data_Stuctures;
using CustomDataStructures.Data_Stuctures;
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
            List<int> list = new List<int>(); 

            CustomList<int> lt = new CustomList<int>();
            lt.Add(2);
            lt.Add(3);
            lt.Add(4);
            lt.Add(5);


            List<int> list2 = new List<int>();
            list2.Add(22);
            list2.Add(33);
            list2.Add(44);
            list2.Add(66);
            list2.Add(77);
            list2.Add(84);
            list2.Add(88);
            IEnumerable<int> en = list2;

            lt.InsertRange(2, en);

            lt.Add(555);
        }  
    }
}
