﻿using System;

namespace _03._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (age >= 16)
            {
                if (gender == "m")
                    Console.WriteLine("Mr.");
                
                else
                    Console.WriteLine("Ms.");
            }

            else if (age < 16)
            {
                if (gender == "m")
                    Console.WriteLine("Master");
                
                else
                    Console.WriteLine("Miss");
            }
        }
    }
}
