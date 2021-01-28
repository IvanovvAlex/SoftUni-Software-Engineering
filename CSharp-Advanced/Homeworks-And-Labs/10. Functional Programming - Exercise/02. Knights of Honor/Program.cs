﻿using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = Reader;
            action(Console.ReadLine());
        }

        static void Reader(string input)
        {
            string[] arr = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in arr)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}
