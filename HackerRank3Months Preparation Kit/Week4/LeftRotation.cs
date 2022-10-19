using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class LeftRotation
    {
        public static void Run() 
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            var result = RotateLeft(2,list);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        private static List<int> RotateLeft(int d, List<int> arr) 
        {
            var list = new List<int>();
            for (int i = d; i < arr.Count; i++)
            {
                list.Add(arr[i]);
            }

            for (int i = 0; i < d; i++)
            {
                list.Add(arr[i]);
            }
            return list;
        }
    }
}
