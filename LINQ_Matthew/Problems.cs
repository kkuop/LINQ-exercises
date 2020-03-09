using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Matthew
{
    class Problems
    {
        public static List<string> ProblemOne(List<string> listOfStrings)
        {
            return listOfStrings.Where(s => s.Contains("th")).ToList();
        }
        public static List<string> ProblemTwo(List<string> listOfStringsWithDuplicates)
        {
            return listOfStringsWithDuplicates.Distinct().ToList();
        }
        public static double ProblemThree(List<string> listOfStringGrades)
        {
            return listOfStringGrades.Average(g => g.Split(',').Select(int.Parse).OrderBy(a => a).Skip(1).Average());
        }
    }
}
