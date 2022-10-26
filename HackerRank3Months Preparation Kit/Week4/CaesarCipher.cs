using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class CaesarCipher
    {
        public static void Run()
        {
            var result = caesarCipher("www.abc.xy", 87);
            Console.WriteLine(result);
        }
        private static string caesarCipher(string s, int k)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in s)
            {
                if (char.IsUpper(character))
                {
                    char ch = (char)(((int)character +
                                    k - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    var asciCode = (((int)character + k - 97) % 26 + 97);
                    char ch = (character >= 97 && character <= 122) ? (char)asciCode:character;
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}
