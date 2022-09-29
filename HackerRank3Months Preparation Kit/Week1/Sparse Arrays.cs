using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class Sparse_Arrays
    {
        public static void Run()
        {
            List<string> strings = new List<string>() { "aba", "baba", "aba", "xzxb" };

            List<string> queries = new List<string>() { "aba", "xzxb", "ab" };

            List<int> result = matchingStrings(strings, queries);
            foreach (var item in result)
            {

                Console.WriteLine(item);
            }
        }
        private static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>() { };

            for (int i = 0; i < queries.Count; i++)
            {
                result.Add(strings.Where(x => x == queries[i]).Count());
            }

            return result;
        }

    }
}
