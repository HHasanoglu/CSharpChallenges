using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class BreakingRecords
    {
        public static void Run()
        {
            var scores = new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1, };
            var results=breakingRecords(scores);
            Console.WriteLine($"{results[0]} {results[1]}");
        }

        /// <summary>
        /// Complete the 'breakingRecords' function below.
        /// The function is expected to return an INTEGER_ARRAY.
        /// The function accepts INTEGER_ARRAY scores as parameter.
        /// </summary>
        /// <param name="scores"></param>
        /// <returns></returns>
        private static List<int> breakingRecords(List<int> scores)
        {
            var minScoreCount = 0;
            var maxScoreCount = 0;
            var minScoreValue = scores[0];
            var maxscoreValue = scores[0];
            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < minScoreValue)
                {
                    minScoreValue = scores[i];
                    minScoreCount++;
                }

                if (scores[i] > maxscoreValue)
                {
                    maxscoreValue = scores[i];
                    maxScoreCount++;
                }

            }

            return new List<int>() { maxScoreCount, minScoreCount };
        }

    }

}
