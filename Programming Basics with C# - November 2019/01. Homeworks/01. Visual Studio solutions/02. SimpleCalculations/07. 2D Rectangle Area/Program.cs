﻿using System;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double area = (x1 - x2) * (y2 - y1);
            double perimeter = 2 * ((x1 - x2) + (y2 - y1));

            Console.WriteLine(Math.Abs(area));
            Console.WriteLine(perimeter));

        }
    }
}
