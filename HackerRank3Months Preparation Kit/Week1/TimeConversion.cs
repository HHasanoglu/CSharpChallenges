using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class TimeConversion
    {
        public static void Run()
        {
            string s = "06:40:03AM";
            timeConversion(s);

        }
        /// <summary>
        /// Given a time in 12 hour AM/PM format, convert it to military (24-hour) time.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string timeConversion(string s)
        {
            var hour = Convert.ToDouble(s.Substring(0,2));
            var minute = s.Substring(3, 2);
            var second = s.Substring(6, 2);
            var ampm = s.Substring(8);
            var newHOur = s.Substring(0, 2);
            if (hour<12 && ampm.ToLower() == "pm")
            {
                hour += 12;
                newHOur = hour.ToString();
            }
            else if(hour==12 && ampm.ToLower()=="am")
            {
                newHOur = "00";
            }

            string time24 = $"{newHOur}:{minute}:{second}";

            return time24;
        }
    }
}
