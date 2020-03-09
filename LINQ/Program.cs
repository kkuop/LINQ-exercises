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
            Problems problems = new Problems();
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            problems.PrintNewList(words);
            Console.ReadKey();
            Console.Clear();
            //*******************
            // PROBLEM 2
            //*******************
            words = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike"};
            problems.PrintListWithoutDups(words);
            Console.ReadKey();
            Console.Clear();
            //*******************
            // PROBLEM 3
            //*******************
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            problems.CalculateClassAvg(classGrades);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
