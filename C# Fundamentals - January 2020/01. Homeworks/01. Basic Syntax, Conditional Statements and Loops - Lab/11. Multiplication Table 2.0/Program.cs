﻿using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = n * multiplier;

            for (int i = multiplier; i <= 10; i++)
            {
                product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }

            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {product}");
            }
        }
    }
}
