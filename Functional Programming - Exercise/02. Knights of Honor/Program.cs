﻿using System;

namespace E02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printex = x => Console.WriteLine($"Sir {string.Join(Environment.NewLine + "Sir ", x)}");
            string[] names = Console.ReadLine().Split();
            printex(names);
        }
    }
}