﻿using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var ch in stringToReverse)
            {
                stack.Push(ch);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop()); 
            }

        }
    }
}
