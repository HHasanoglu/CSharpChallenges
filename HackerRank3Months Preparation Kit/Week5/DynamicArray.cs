using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class DynamicArray
    {
        public static void Run()
        {
            var list = new List<List<int>>()
            {
                new List<int>(){1, 0 ,5 },
                new List<int>(){ 1, 1, 7},
                new List<int>(){1, 0, 3},
                new List<int>(){2, 1, 0},
                new List<int>(){2, 1, 1}
           };

            var result = dynamicArray(2, list);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        private static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            var seqList = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                seqList.Add(new List<int>());
            }

            int lastAnswer = 0;
            var lastAnswers = new List<int>();
            foreach (var query in queries)
            {
                var index = (query[1] ^ lastAnswer) % n;
                if (query.First() == 1)
                {
                    seqList[index].Add(query.Last());
                }
                else
                {
                    int y = query.Last();
                    int size = seqList[index].Count;
                    lastAnswer = seqList[index][y % size];
                    lastAnswers.Add(lastAnswer);
                }
            }
            return lastAnswers;
        }
    }
}
