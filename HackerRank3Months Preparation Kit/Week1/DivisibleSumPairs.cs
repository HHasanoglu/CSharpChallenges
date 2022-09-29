using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class DivisibleSumPairs
    {
        public static void Run() 
        {
            int n = 6, k = 3;
            List<int> ar = new List<int>() { 1, 3, 2, 6, 1, 2 };
            int result=divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
        private static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            var count = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    var sum = ar[i] + ar[j];
                    if (sum % k == 0) count++;
                }
            }
            return count;
        }
    }
}
