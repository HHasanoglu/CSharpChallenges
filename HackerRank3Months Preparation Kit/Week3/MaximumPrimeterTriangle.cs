using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class MaximumPrimeterTriangle
    {
        public static void Run()
        {
            var sticks = new List<int>();

            var result =maximumPerimeterTriangle(sticks);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
        private static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            List<int> numbers = new List<int>();
            sticks.Sort();
            for (int i = sticks.Count - 1; i >= 2; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (sticks[i] < sticks[j] + sticks[k] &&
                           sticks[j] < sticks[i] + sticks[k] &&
                           sticks[k] < sticks[i] + sticks[j])
                        {
                            numbers.Add(sticks[k]);
                            numbers.Add(sticks[j]);
                            numbers.Add(sticks[i]);
                            return numbers;
                        }
                    }
                }
            }
            numbers.Add(-1);
            return numbers;
        }

    }
}
