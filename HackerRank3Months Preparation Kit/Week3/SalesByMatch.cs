using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class SalesByMatch
    {
        public static void Run() 
        {
            var ar = new List<int>(){ 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = sockMerchant(9, ar);
            Console.WriteLine(result);
        }

        private static int sockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            int pairs = 0;
            for (int i = 1; i < ar.Count; i++)
            {
                if (ar[i] == ar[i - 1])
                {
                    pairs++;
                    i++;
                }
            }
            return pairs;
        }

    }
}
