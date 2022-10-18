using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class MigratoryBirds
    {

        public static void Run() 
        {
            List<int> arr = new List<int>() {1,1,2,2,3 };
            var result=migratoryBirds(arr);
            Console.WriteLine(result);
        }

        private static int migratoryBirds(List<int> arr)
        {
            int[] counts = new int[arr.Max()];
            for (int i = 0; i < arr.Count; i++)
            {
                counts[arr[i] - 1]++;
            }
            var max = 0;
            var index = 0;
            for (int i = 0; i < arr.Max(); i++)
            {
                if (counts[i] > max)
                {
                    max = counts[i];
                    index = i + 1;
                }
            }

            return index;
        }
    }
}
