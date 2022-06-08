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
			int[,] array = {
			{1, 6, 3, 2, 5},
			{2, 7, 2, 8, 7},
			{3, 8, 1, 6, 4},
			{4, 9, 0, 5, 0},
			{5, 4, 7, 3, 9}
			};
			 
			SumOfDiagonalTwoDimensionalArray.ArrayDiagonal(array);
		}  
    }
}
