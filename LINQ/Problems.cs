using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Problems
    {
        public void PrintNewList(List<string> words)
        {
            var newList = words.Where(m => m.Contains("th"));
            foreach (string w in newList)
            {
                Console.WriteLine(w);
            }
        }
        public void PrintListWithoutDups(List<string> words)
        {
            var newList = words.Distinct();
            foreach (string w in newList)
            {
                Console.WriteLine(w);
            }
        }
        public void CalculateClassAvg(List<string> classGrades)
        {
            var result = classGrades.Average(c => c.Split(',').Select(int.Parse).OrderBy(n => n).Skip(1).Average());
            Console.WriteLine(result);
        }
        public void CountLettersInName(string name)
        {
            var zipper = name.ToList().OrderBy(n => n.ToString().ToUpper()).GroupBy(n => n.ToString().ToUpper()).Select(n => n.Key).Zip(name.ToList().OrderBy(n => n.ToString().ToUpper()).GroupBy(n=>n.ToString().ToUpper()).Select(n => n.Count()), (a, b) => (a.ToString() + b.ToString()));
            foreach (var n in zipper)
            {
                Console.Write(n);
            }
        }
    }
}
