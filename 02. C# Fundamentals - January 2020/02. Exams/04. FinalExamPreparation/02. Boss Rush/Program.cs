﻿using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[|](?<boss>[A-Z]{4,})[|]:[#](?<title>[A-Za-z]+[ ][A-Za-z]+)[#]$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string boss = match.Groups["boss"].Value;
                    string title = match.Groups["title"].Value;

                    Console.WriteLine($"{boss}, The {title}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }

                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
