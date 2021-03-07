using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> texto = new List<string>();
            texto.Add("palavra 1");
            texto.Add("palavra 2");
            texto.Add("palavra 3");
            texto.Add("palavra 4");
            texto.Add("palavra 5");

            int contador = 0;

            foreach (string palavra in texto)
            {
                Console.WriteLine("Iteração {0}: {1}", contador, palavra);
                contador++;
            }
            Console.ReadKey();

        }
    }
}
