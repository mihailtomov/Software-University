﻿using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
