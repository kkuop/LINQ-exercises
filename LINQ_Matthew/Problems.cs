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
        public static string ProblemFour(string stringInput)
        {
            IEnumerable<IGrouping<string, char>> letters = stringInput.ToCharArray().OrderBy(a => a.ToString().ToUpper()).GroupBy(a => a.ToString().ToUpper());
            IEnumerable<string> keys = letters.Select(a => a.Key.ToString().ToUpper());
            IEnumerable<int> counts = letters.Select(a => a.Count());
            string[] lettersWithCounts =  keys.Zip(counts, (a, b) => a.ToString() + b.ToString()).ToArray();
            string result = lettersWithCounts.Aggregate((a, b) => a + b);
            return result;
        }
        public static string ProblemFourSingleLine(string letters)
        {
            return letters.ToCharArray().OrderBy(a => a.ToString().ToUpper()).GroupBy(a => a.ToString().ToUpper()).Select(a=>a.Key.ToString().ToUpper()).Zip(letters.ToCharArray().OrderBy(a=>a.ToString().ToUpper()).GroupBy(a => a.ToString().ToUpper()).Select(a => a.Count()), (a, b) => a.ToString() + b.ToString()).ToArray().Aggregate((a,b)=>a+b);
        }
    }
}
