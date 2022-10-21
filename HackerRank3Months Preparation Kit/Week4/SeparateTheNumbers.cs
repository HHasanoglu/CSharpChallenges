using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class SeparateTheNumbers
    {
        public static void Run() 
        {
            string[] array = {
"00000000000000000000000000000000",
"11111111111111111111111111111111",
"22222222222222222222222222222222",
"33333333333333333333333333333333",
"44444444444444444444444444444444",
"55555555555555555555555555555555",
"66666666666666666666666666666666",
"77777777777777777777777777777777",
"88888888888888888888888888888888",
"10001001100210031004100510061007"};
            foreach (var item in array)
            {
                separateNumbers(item);
            }
        }

        private static void separateNumbers(string s)
        {
            var result = "";
            if (s.Length > 1)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    var number = Convert.ToInt64(s.Substring(0, i + 1));
                    var temp = number;
                    var txt = "";
                    while (txt.Length < s.Length)
                    {
                        txt += Convert.ToString(temp);
                        temp++;
                    }
                    if (txt == s)
                    {
                        result = $"YES {number}";
                        break;
                    }
                    else result = "NO";
                }

            }
            else
            {
                result = "NO";
            }
            Console.WriteLine(result);
        }
    }
}
