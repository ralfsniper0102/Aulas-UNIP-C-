﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine("Iteração {0}", i);
            }
            Console.ReadKey();
        }
    }
}
