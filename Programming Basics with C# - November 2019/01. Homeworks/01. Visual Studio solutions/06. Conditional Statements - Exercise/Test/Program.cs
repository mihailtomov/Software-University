﻿using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string role = "Administrator";
            if (role != "Administrator")
            {
                Console.WriteLine("No permission");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
