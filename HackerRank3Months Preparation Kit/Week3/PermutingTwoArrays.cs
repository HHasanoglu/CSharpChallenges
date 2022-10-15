using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class PermutingTwoArrays
    {

        public static void Run() 
        {
            var A = new List<int>() { 2, 1, 3 };
            var B = new List<int>() { 7, 8, 9 };
            var k = 10;
            var result = twoArrays(k, A, B);
            Console.WriteLine(result);

        }


    private static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();
        B.Sort();
        B.Reverse();
        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] + B[i] < k)
            {
                return "NO";
            }
        }
        return "YES";
    }
    }

}
