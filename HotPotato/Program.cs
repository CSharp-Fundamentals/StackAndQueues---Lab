using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> children = new Queue<string>(names);
            int potatoTosses = 0;

            while (children.Count>1)
            {
                potatoTosses++;

                string kid = children.Dequeue();

                if (potatoTosses==n)
                {
                    potatoTosses = 0;
                    Console.WriteLine("Removed "+kid);
                }
                else
                {
                    children.Enqueue(kid);
                }
            }
            Console.WriteLine("Last is "+children.Dequeue());
        }
    }
}
