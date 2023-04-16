using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROBLEM 2
            Console.WriteLine("Problem Two:\nWhat integers would you like to reverse order? (seperate by commas)");
            
            string[] ReverseIntegers = Console.ReadLine().Split(',');

            Stack<int> IntegerStack = new Stack<int>();

            foreach (string Occurrence in ReverseIntegers)
            {
                if (int.TryParse(Occurrence, out int j))
                {
                    IntegerStack.Push(j);
                }
                else
                {
                    Console.WriteLine("String '"+Occurrence+"' could not be parsed.");
                }
            }

            ProblemHelper.ReverseOrder(IntegerStack);
            
            //PROBLEM 7
            Console.WriteLine("Problem Seven:\nEnter a list of integers. (seperate by commas)");

            string[] CountIntegers = Console.ReadLine().Split(',');

            List<int> ProblemIntegers = new List<int>();

            foreach (string Occurrence in CountIntegers)
            {
                if (int.TryParse(Occurrence, out int j))
                {
                    ProblemIntegers.Add(j);
                }
                else
                {
                    Console.WriteLine("String'"+Occurrence+"' could not be parsed.");
                }
            }

            ProblemHelper.OccuranceAmount(ProblemIntegers);

            //PROBLEM 9
            Console.WriteLine("Problem Nine:\nEnter a starter integer.");
            string SequenceStart = Console.ReadLine();

            if (int.TryParse(SequenceStart, out int test))
            {
                ProblemHelper.SequencePrinter(test);
            }
            else
            {
                Console.WriteLine("String'" + SequenceStart + "' could not be parsed.");
            }

            Console.ReadKey();
        }
    }
}
