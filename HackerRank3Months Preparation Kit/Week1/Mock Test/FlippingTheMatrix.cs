using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class FlippingTheMatrix
    {
        public static void Run() 
        {
            List<List<int>> mat = new List<List<int>>(){new List<int>(){112, 42, 83, 119 },
                                                        new List<int>(){56,   125,  56,  49 },
                                                        new List<int>(){15,   78,   101,  43 },
                                                        new List<int>(){ 62,  98,  114, 108 }};
            var sum = FlippingMatrix(mat);
        }
        private static int FlippingMatrix(List<List<int>> matrix) 
        {
            var rowNumber = matrix.Count;
            var colNumber = matrix[0].Count;
            int sum = 0;

            for (int row = 0; row < rowNumber / 2; row++)
            {
                for (int col = 0; col < colNumber / 2; col++)
                {
                    var colflip = rowNumber - row - 1;
                    var rowflip = colNumber - col - 1;
                    sum += Math.Max(Math.Max(matrix[row] [col], matrix[row][rowflip]),
                                    Math.Max(matrix[colflip][col], matrix[colflip][rowflip]));
                }
            }
            return sum;
        }
    }
}
