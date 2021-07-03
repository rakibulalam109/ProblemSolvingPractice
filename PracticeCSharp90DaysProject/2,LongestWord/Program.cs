﻿using System;

namespace _2_LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to find the longest word in a string.

            var input = Console.ReadLine().Split(' ');

            
            int topLength = 0;
            string store = string.Empty;

            foreach (var item in input)
            {
                int newItem = item.Length;

                if (newItem > topLength)
                {
                    store = item;
                    topLength = store.Length;
                }
                

            }
            Console.WriteLine(store);
        }
    }
}
