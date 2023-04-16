using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    internal class ProblemHelper
    {
        /// <summary>
        /// This method takes a stack of integers and prints them in reverse order.
        /// </summary>
        /// <param name="AllIntegers"> The stack of integers to be reversed. </param>
        public static void ReverseOrder(Stack<int> AllIntegers)
        {
            Console.Write("Reversed: ");
            while (AllIntegers.Count > 0)
            {
                int NextInteger = AllIntegers.Pop();
                Console.Write(NextInteger.ToString() + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This function takes an array of integers and tracks how many times each integer occurs.
        /// </summary>
        /// <param name="AllIntegers"> The inputted integer. </param>
        public static void OccuranceAmount(List<int> AllIntegers)
        {
            int[] Occurrences = new int[1001];

            foreach (int Occurrence in AllIntegers)
            {
                Occurrences[Occurrence] += 1;
            }

            for (int i = 0; i < Occurrences.Length; i++)
            {
                if (Occurrences[i] != 0)
                {
                    Console.WriteLine(i.ToString() + ": " + Occurrences[i].ToString() + " times");
                }
            }
        }

        /// <summary>
        /// This method takes an inputted integer and outputs the first 50 letters in a sequence.
        /// </summary>
        /// <param name="StartInteger"> This is the start integer in the sequence. </param>
        public static void SequencePrinter(int StartInteger)
        {
            Console.WriteLine("\nSequence: ");

            Queue<int> AllIntegers = new Queue<int>();

            AllIntegers.Enqueue(StartInteger);

            Console.WriteLine(StartInteger);

            for (int i = 0; i < 17; i ++)
            {
                AllIntegers.Enqueue(AllIntegers.Peek() + 1);
                Console.WriteLine(AllIntegers.Peek() + 1);

                if (i == 16)
                {
                    break;
                }

                AllIntegers.Enqueue(2 * AllIntegers.Peek() + 1);
                Console.WriteLine(2 * AllIntegers.Peek() + 1);

                AllIntegers.Enqueue(AllIntegers.Peek() + 2);
                Console.WriteLine(AllIntegers.Peek() + 2);

                AllIntegers.Dequeue();
            }
            Console.WriteLine("The first 50 integers in the sequence have been printed.");
        }
    }
}
