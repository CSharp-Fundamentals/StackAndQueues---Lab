using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> carNames = new Queue<string>();

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line=="end")
                {
                    break;
                }

                if (line=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (carNames.Count<1)
                        {
                            break;
                        }
                        counter++;
                        string passedCar = carNames.Dequeue();
                        Console.WriteLine($"{passedCar} passed!");
                    }
                    continue;
                }


                carNames.Enqueue(line);
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
