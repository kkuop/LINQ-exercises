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
        public static string ProblemFour(string letters)
        {
            string result = "";
            string[] charArray = letters.ToCharArray().Select(a => a.ToString().ToUpper()).OrderBy(a=>a).ToArray();
            string myString =  charArray.Distinct().OrderBy(a=>a).Zip(charArray.GroupBy(a=>a).Select(a=>a.Count().ToString()), (a, b) => a+b).Aggregate((a, b) => result+= (a+b));
            return result;
            //Split letters into char array
            //Sort alphabetically
            //Count how many of each character there are
            //Collapse so that each character appears once
            //Intersprese counts
        }
    }
}
