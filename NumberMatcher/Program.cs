using System;
using System.Collections;

namespace NumberMatcher
{
    class Program
    {
       static bool checkOrder(string source)
        {
            Stack openStack = new Stack();
            int i = 0;
            char temp;
            while (i < source.Length)
            {
                if (openStack.Count == 0)
                {
                    openStack.Push(source[i]);
                    i++;
                    continue;
                }

                temp = (char)openStack.Peek();

                if (source[i] == temp)
                {
                    openStack.Pop();
                }
                else if (source[i] != temp)
                {
                    openStack.Push(source[i]);
                }
                i++;
            }

            return openStack.Count == 0;
        }

        static void Main(string[] args)
        {
           Console.WriteLine(checkOrder("98766789"));
        }
    }
}

