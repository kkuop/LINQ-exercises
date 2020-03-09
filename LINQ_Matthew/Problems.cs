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
            return listOfStringsWithDuplicates.Distinct<string>().ToList();
        }
        //public static double ProblemThree(List<string> listOfStringGrades)
    }
}
