using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    class GradingStudents
    {
        public static void Run() 
        {
            var grades = new List<int>() {73,67,38,33 };
            var RoundedGrades = gradingStudents(grades);
            foreach (var item in RoundedGrades)
            {
                Console.WriteLine(item);
            }
        }
        private static List<int> gradingStudents(List<int> grades)
        {
            var roundedGrades = new List<int>();
            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    roundedGrades.Add(grade);
                }
                else
                {

                    if (grade % 5 < 3)
                    {
                        roundedGrades.Add(grade);
                    }
                    else
                    {
                        roundedGrades.Add(5 * (grade / 5 + 1));
                    }
                }
            }
            return roundedGrades;

        }
    }
}
