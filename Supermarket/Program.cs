using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    Console.WriteLine($"{people.Count} people remaining.");
                    break;
                }

                if (input=="Paid")
                {
                    Console.WriteLine(string.Join("\n",people));
                    people.Clear();
                    continue;
                }

                people.Enqueue(input);
            }
        }
    }
}
