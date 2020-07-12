﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (query[0] == 1)
                {
                    stack.Push(query[1]);
                }

                if (query[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }

                if (query[0] == 3)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }

                if (query[0] == 4)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
