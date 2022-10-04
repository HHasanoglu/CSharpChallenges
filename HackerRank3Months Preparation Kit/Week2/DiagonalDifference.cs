using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    class DiagonalDifference
    {

        public static void Run() 
        {
            List<List<int>> mat = new List<List<int>>(){new List<int>(){1, 2, 3},
                                                        new List<int>(){4, 5, 6},
                                                        new List<int>(){9, 8, 9} };
            var diagonalDiff=diagonalDifference(mat);
            Console.WriteLine(diagonalDiff);

        }
        private static int diagonalDifference(List<List<int>> arr)
        {
            var rowCount = arr.Count;
            var colCount = arr[0].Count;
            var leftToRightDiag = 0;
            var rightToLeftDiag = 0;
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    if (row == col) leftToRightDiag += arr[row][col];
                    if (col == colCount - row - 1) rightToLeftDiag += arr[row][col];
                }
            }

            return Math.Abs(leftToRightDiag - rightToLeftDiag);

        }
    }
}
