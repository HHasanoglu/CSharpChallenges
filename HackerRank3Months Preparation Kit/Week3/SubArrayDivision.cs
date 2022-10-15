using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class SubArrayDivision
    {
        public static void Run()
        {
            var list = new List<int>() { 1, 1, 1, 1, 1, 1 };
            var d = 3;
            var m = 2;
            int count=birthday(list, d, m);
            Console.WriteLine(count);
        }

        private static int birthday(List<int> s, int d, int m)
        {
            var count = 0;
            for (int i = 0; i < s.Count - m + 1; i++)
            {
                var sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }
                if (sum == d) count++;
            }
            return count;
        }

    }
}
