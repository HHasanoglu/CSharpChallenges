using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class Pangrams
    {
        public static void Run()
        {
            string test = "We promptly judged antique ivory buckles for the next prize";
            Console.WriteLine(pangrams(test)); 
        }

        private static string pangrams(string s) 
        {
            s = s.ToLower();
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            foreach (char character in s)
            {
                if (character != ' ' && !alphabet.ContainsKey(character))
                {
                    alphabet.Add(character, (int)character);
                }
            }

            string result = alphabet.Count==26 ? "pangram":"not pangram";

            return result;
        }

    }
}
