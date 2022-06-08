using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures.Data_Stuctures
{
    class SumOfDiagonalTwoDimensionalArray
    {
		public static void ArrayDiagonal(int[,] array)
		{
			int sum = 0; 
			int rowLength = array.GetLength(0);
			int columnLength = array.GetLength(1);
			Console.WriteLine("\n\nDiagonal Array Element: ");
			Console.WriteLine("------------------------------------------------ ");

			for (int row = 0; row < rowLength; row++)
			{
				for (int column = 0; column < columnLength; column++)
				{
					Console.Write("  ");
					if (row == column)
					{
						Console.Write(array[row, column] + " ");
						sum += array[row, column]; 
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n\nDiagonal Array Element Sum : " + sum);
		}
	} 
}

