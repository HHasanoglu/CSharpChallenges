using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class MinMaxSum
    {

        public static void Run()
        {
            int[] arr = { 256741038,623958417, 467905213 ,714532089 ,938071625 };

            miniMaxSum(arr.ToList());

        }


        /// <summary>
        ///  Given N positive integers, find the minimum and maximum values
        ///  that can be calculated by summing exactly N-1 of the N integers.
        ///  Then print the respective minimum and maximum values as a single line
        ///  of two space - separated long integers
        /// </summary>
        /// <param name="arr"></param>
        private static void miniMaxSum(List<int> arr)
        {
            long minimum = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                minimum += arr[i];
            }

            arr.Reverse();
            long maximum = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                maximum += arr[i];
            }

            Console.Write($"{minimum} {maximum}");


        }


    }

}