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
            //HashSet<int> hs = new HashSet<int>();
            //hs.



            CustomHashSet<int> chs = new CustomHashSet<int>();
            
            chs.Add(2);
            chs.Add(2);
            chs.Add(17);
            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }


            CustomDictionary<int, int> dict = new CustomDictionary<int, int>();
            dict.Add(-1, -1);
            dict.Add(1, -1);
            dict.Add(22, -1);
            dict.ContainsKey(9);
            dict.GetValue(9);

            CustomHashTable customHashTable = new CustomHashTable();
            customHashTable.Add(23, 78);
            customHashTable.Add("salam", 2);
        }  
    }
}
