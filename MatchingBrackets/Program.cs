using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> bracketIdx = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    bracketIdx.Push(i);
                }

                if (input[i] ==')')
                {
                    int startIdx = bracketIdx.Pop();
                    Console.WriteLine(input.Substring(startIdx, i-startIdx+1));
                }
            }
        }
    }
}
