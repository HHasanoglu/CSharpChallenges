using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class DrawingBook
    {
        public static void Run()
        {
            var result = pageCount(6, 5);
            Console.WriteLine(result);
        }
        private static int pageCount(int n, int p)
        {
            var count1 = 0;
            for (int i = 0; i < n; i += 2)
            {
                if (p - i < 2)
                {
                    break;
                }
                count1++;
            }
            var count2 = 0;
            for (int i = n; i > 0; i -= 2)
            {
                if (i % 2 == 0 && i - p == 1)
                {
                    count2++;
                    break;
                }
                else if (i - p < 2)
                {
                    break;
                }
                count2++;
            }
            return Math.Min(count1, count2);
        }
    }
}
