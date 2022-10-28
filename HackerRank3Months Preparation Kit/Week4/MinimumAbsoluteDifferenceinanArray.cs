using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class MinimumAbsoluteDifferenceinanArray
    {

        public static void Run() 
        {
            var list = new List<int>() { -2, 2, 4 };
            var result = GetMinimumValue(list);
            Console.WriteLine(result);

        }
        private static double GetMinimumValue(List<int> arr) 
        {
            arr.Sort();
            var difference = Math.Abs(arr[0] - arr[1]);
            for (int i = 1; i < arr.Count; i++)
            {
                difference = Math.Min(difference, Math.Abs(arr[i] - arr[i - 1]));
            }
            return difference;
        }
    }
}
