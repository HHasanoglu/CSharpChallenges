using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class MissingNumbers
    {
        public static void Run()
        {
            var arr = new List<int>() { 1, 2, 3, 4, 5 };
            var brr = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = missingNumbers(arr, brr);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            var missing = new List<int>();
            brr.Sort();
            foreach (var number in brr)
            {
                if (arr.Contains(number))
                {
                    arr.Remove(number);
                }
                else
                {
                    missing.Add(number);
                }
            }
            return missing.Distinct().ToList();
        }
    }
}
