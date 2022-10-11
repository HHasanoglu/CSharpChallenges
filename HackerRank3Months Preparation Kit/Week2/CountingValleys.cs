using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    class CountingValleys
    {
        public static void Run()
        {
            string path = " UDDDUDUU";
            int count = path.Length;
            var diagonalDiff = countingValleys(count, path);
            Console.WriteLine(diagonalDiff);

        }
        private static int countingValleys(int steps, string path)
        {
            var count = 0;
            var numValley = 0;
            foreach (char character in path)
            {
                if (character == 'U') count++;
                else count--;

                if (count == 0 && character == 'U') numValley++;
            }
            return numValley;
        }
    }
}
