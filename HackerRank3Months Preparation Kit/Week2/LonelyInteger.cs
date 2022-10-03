using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class LonelyInteger
    {
        public static void Run() 
        {
            var a = new List<int>() { 1, 2, 3, 4, 3, 2,1 };
            var result=lonelyinteger(a);
            Console.WriteLine(result);
        }
        private static int lonelyinteger(List<int> a)
        {
            var uniqElement = 0;
            for (int i = 0; i < a.Count; i++)
            {
                var count = 0;
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[i] == a[j]) count++;
                }
                if (count == 1) return a[i];
            }
            return uniqElement;
        }
    }

}
