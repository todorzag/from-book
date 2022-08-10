﻿using System.Text;

namespace Problem24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that reads a string from the console and replaces every
            sequence of identical letters in it with a single letter (the repeating
            letter). Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
            */

            string input = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || input[i - 1] != input[i])
                {
                    stringBuilder.Append(input[i]);
                } 
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}