using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Matthew
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>() { "the", "bike", "this", "tenth", "mathematics" };
            foreach (string word in Problems.ProblemOne(myList))
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
