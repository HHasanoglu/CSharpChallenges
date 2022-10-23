using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class ClosestNumbers
    {
        public static void Run()
        {
            var list = new List<int>() { 5, 2, 3, 4, 1 };
            var resutls=closestNumbers(list);
            foreach (var item in resutls)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> closestNumbers(List<int> arr)
        {
            arr.Sort();
            var resutl = new List<int>();
            var minimum = arr[1] - arr[0];
            for (int i = 0; i < arr.Count - 1; i++)
            {
                var num1 = arr[i];
                var num2 = arr[i + 1];
                minimum = Math.Min(minimum, Math.Abs(num2 - num1));
            }

            for (int i = 0; i < arr.Count - 1; i++)
            {
                var num1 = arr[i];
                var num2 = arr[i + 1];
                if (num2 - num1 == minimum)
                {
                    resutl.Add(num1);
                    resutl.Add(num2);
                }
            }

            return resutl;
        }

    }
}
