using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    class CamelCase4
    {
        public static void Run()
        {
            CamelCase();
        }

        private static void CamelCase()
        {
            var sr = new StreamReader(@"..\..\..\Week1\Week1TextFiles\CamelCase4.txt");
            var inputs = sr.ReadToEnd().Split("\r\n").Where(x => x != "").ToList();


            foreach (string text in inputs)
            {
                string[] textParts = text.Split(";");
                string name = textParts[2];
                string optiontext = textParts[1].ToLower();
                StringBuilder result = new StringBuilder();
                if (textParts[0].ToLower() == "c")
                {
                    var nameParts = name.Split(" ");
                    for (int i = 0; i < nameParts.Length; i++)
                    {
                        if (optiontext == "c")
                        {
                            result.Append(char.ToUpper(nameParts[i][0]));
                            result.Append(nameParts[i][1..]);
                        }
                        else
                        {
                            if (i == 0) result.Append(nameParts[i]);
                            else
                            {
                                result.Append(char.ToUpper(nameParts[i][0]));
                                result.Append(nameParts[i][1..]);
                            }
                        }
                    }
                    if (optiontext == "m") result.Append("()");
                }
                else
                {
                    if (optiontext == "m") name=name.TrimEnd('(',')');
                        foreach (char character in name)
                        {
                            if (char.IsLower(character)) result.Append(character);
                            else 
                            {
                                result.Append(" " + char.ToLower(character));
                            }
                        }
                }
                Console.WriteLine(result.ToString().TrimStart());
            }
        }
    }
}
