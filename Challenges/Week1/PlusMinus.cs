using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public static class PlusMinus
    {
        public static void Run() 
        {
            var [] arr = -4, 3, -9, 0, 4, 1];

            plusMinus(arr.);

        }

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
