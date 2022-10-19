using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class PickingNumbers
    {
        public static void Run() 
        {
            var list = new List<int>() { 4, 6, 5, 3, 3, 1 };
            var result = pickingNumbers(list);
            Console.WriteLine(result);
        }
        private static int pickingNumbers(List<int> a)
        {
            a.Sort();
            var k = 1;
            var maxLength = 1;
            for (int i = 0; i < a.Count ; i++)
            {
                var min = a[i];
                var max = a[i];
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[j] > max) max = a[j];
                    if (a[j] < min) min = a[j];

                    if (max - min <= k)
                    {
                        var arrLength = j - i + 1;
                        if (maxLength<arrLength)
                        {
                            maxLength = arrLength;
                        }
                    }
                }
            }
           return maxLength;
        }
    }
}
