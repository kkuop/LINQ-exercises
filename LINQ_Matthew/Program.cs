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
            List<string> thList = new List<string>() { "the", "bike", "this", "tenth", "mathematics" };
            foreach (string word in Problems.ProblemOne(thList))
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            List<string> listWithDuplicate = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            foreach (string name in Problems.ProblemTwo(listWithDuplicate))
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
