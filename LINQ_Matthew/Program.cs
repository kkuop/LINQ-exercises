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
            List<string> gradesList = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            Console.WriteLine(Problems.ProblemThree(gradesList));
            Console.ReadLine();
        }
    }
}
