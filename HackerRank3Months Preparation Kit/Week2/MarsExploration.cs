using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class MarsExploration
    {

        public static void Run() 
        {
            string test = "SOSSPSSQSSOR";
            Console.WriteLine(marseExplorarion(test)); 
        }

        private static int marseExplorarion(string s) 
        {
            string message = "SOS";
            s = s.ToUpper();
            var count = 0;
            for (int i = 0; i < s.Length / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (s[3 * i + j] != message[j]) count++;
                }
            }
            return count;
        }
    }
}
