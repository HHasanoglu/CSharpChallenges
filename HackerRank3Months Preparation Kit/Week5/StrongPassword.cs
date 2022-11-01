using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public static class StrongPassword
    {
        public static void Run() 
        {
            var result=minimumNumber(5, "2bb#A");
            Console.WriteLine(result);
        }

        public static int minimumNumber(int n, string password)
        {
            var min = 0;
            var count = 0;
            var numbers = "0123456789";
            var lower_case = "abcdefghijklmnopqrstuvwxyz";
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var special_characters = "!@#$%^&*()-+";

            if (password.IndexOfAny(numbers.ToCharArray()) == -1) count++;
            if (password.IndexOfAny(lower_case.ToCharArray()) == -1) count++;
            if (password.IndexOfAny(upper_case.ToCharArray()) == -1) count++;
            if (password.IndexOfAny(special_characters.ToCharArray()) == -1) count++;

            return count > 6 - n ? count : 6 - n;
        }
    }
}
