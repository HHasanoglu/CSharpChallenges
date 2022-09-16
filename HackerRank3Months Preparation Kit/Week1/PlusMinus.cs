using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class PlusMinus
    {
        public static void Run() 
        {
            int[] arr = { -4, 3, -9, 0, 4, 1 };

            plusMinus(arr.ToList());

        }
        /// <summary>
        /// Given an array of integers, calculate the ratios of its elements
        /// that are positive, negative, and zero. Print the decimal value of
        /// each fraction on a new line with  places after the decimal.
        /// </summary>
        /// <param name="arr"></param>
        private static void plusMinus(List<int> arr)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            var length = arr.Count;
            foreach (int number in arr)
            {
                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine($"{(double)positiveCount / length:F6}");
            Console.WriteLine($"{(double)negativeCount / length:F6}");
            Console.WriteLine($"{(double)zeroCount / length:F6} ");
        }
    }

}
