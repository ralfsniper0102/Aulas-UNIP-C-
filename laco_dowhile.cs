using System;

namespace ConsoleApp1
{
    class Programa
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Iteração {0}", i);
                i++;
            } while (i < 5);
            Console.ReadKey();
        }
        
    }
}
