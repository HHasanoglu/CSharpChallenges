using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class TheFullCountingSort
    {
        public static void Run() 
        {
            var list = new List<List<string>>() 
            {
                         new List<string>(){"0","ab"},
                         new List<string>(){"6","cd"},
                         new List<string>(){"0","ef"},
                         new List<string>(){"6","gh"},
                         new List<string>(){"4","ij"},
                         new List<string>(){"0","ab"},
                         new List<string>(){"6","cd"},
                         new List<string>(){"0","ef"},
                         new List<string>(){"6","gh"},
                         new List<string>(){"0","ij"},
                         new List<string>(){"4","that"},
                         new List<string>(){"3","be"},
                         new List<string>(){"0","to"},
                         new List<string>(){"1","be"},
                         new List<string>(){"5","question"},
                         new List<string>(){"1","or"},
                         new List<string>(){"2","not"},
                         new List<string>(){"4","is"},
                         new List<string>(){"2","to"},
                         new List<string>(){"4","the"}};

            countSort(list);
        }

        public static void countSort(List<List<string>> arr)
        {
            var result = new List<List<string>>();
            foreach (var list in arr)
            {
                var index = Convert.ToInt16(list[0]);
                var value = list[1];
                result[index].Add(value);
            }


        }
    }
}
