using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class NumberLineJumps
    {
        public static void Run() 
        {
            var result = kangaroo(2, 1, 1, 2);
            Console.WriteLine(result);
        }

        private static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var startDifference = x2 - x1;
            var speedDifference = v1 - v2;
            if (v1 > v2 && startDifference % speedDifference == 0) return "YES";
            else return "NO";
        }
    }
}
