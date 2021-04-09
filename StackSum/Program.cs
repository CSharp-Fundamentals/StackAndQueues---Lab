using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                numbers.Push(array[i]);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line=="end")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0].ToLower();

                switch (command)
                {
                    case "add":
                        int first = int.Parse(tokens[1]);
                        int second = int.Parse(tokens[2]);

                        numbers.Push(first);
                        numbers.Push(second);
                        break;
                    case "remove":
                        int count = int.Parse(tokens[1]);

                        if (count<=numbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");

        }
    }
}
