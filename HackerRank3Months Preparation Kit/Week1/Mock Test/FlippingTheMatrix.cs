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
                                                        new List<int>(){6,   125,  56,  49 },
                                                        new List<int>(){5,   78,   101,  43 },
                                                        new List<int>(){ 62,  98,  114, 108 }};
            var sum = FlippingMatrix(mat);
        }
        private static int FlippingMatrix(List<List<int>> matrix) 
        {
            var rowNumber = matrix.Count;
            var colNumber = matrix[0].Count;
            return 0;
        }
    }
}
