using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = new string[5];
            texto[0] = "palavra 1";
            texto[1] = "palavra 2";
            texto[2] = "palavra 3";
            texto[3] = "palavra 4";
            texto[4] = "palavra 5";

            int contador = 0;

            foreach (string palavra in texto)
            {
                Console.WriteLine("iteração {0}: {1}", contador, palavra);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
