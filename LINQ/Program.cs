using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //*******************
            // PROBLEM 1
            //*******************
            List<string> words = new List<string>() {"the", "bike", "this", "it", "tenth", "mathematics" };
            var newList = words.Where(m => m.Contains("th"));
            foreach (string w in newList)
            {
                Console.WriteLine(w);
            }
            Console.ReadKey();

            //*******************
            // PROBLEM 2
            //*******************

        }
    }
}
