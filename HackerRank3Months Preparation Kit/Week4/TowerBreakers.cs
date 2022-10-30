using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class TowerBreakers
    {
        public static void Run()
        {

            Console.WriteLine(towerBreakers(2,2)); 
        }
        private static int towerBreakers(int n, int m)
        {
            return (n % 2 == 0 || m == 1) ? 2 : 1;
        }
    }
}
