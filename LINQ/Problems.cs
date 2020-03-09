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
    }
}
