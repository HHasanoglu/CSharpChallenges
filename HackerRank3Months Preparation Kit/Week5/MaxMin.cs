using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class MaxMin
    {
        public static void Run()
        {

            Console.WriteLine(maxMin(2, new List<int>() { 1, 2, 3, 4, 6, 8, 12 }));
        }
        private static int maxMin(int k, List<int> arr)
        {
            arr.Sort();
            int min = arr[k - 1] - arr[0];
            for (int i = 1; i <= arr.Count - k; i++)
            {
                min = Math.Min(min, arr[i + k - 1] - arr[i]);
            }

            return min;
        }
    }


}
