﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Hello World!");
            int cislo = int.Parse(Console.ReadLine());
            for (int j = 0; j < cislo; j++)
            {
                Console.WriteLine("ahoj");

            }
            Console.ReadKey();
        }
    }
}
