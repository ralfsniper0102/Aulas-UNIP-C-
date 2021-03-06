using System;

namespace ConsoleApp3
{
    class Programa
    {
        static void Main(string[] args)
        {
            int numero =0;
            Console.Write("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2==0)
            {
                Console.WriteLine("o número {0} é par",numero);
            }
            else
            {
                Console.WriteLine("o número {0} é impar",numero);
            }
            Console.ReadKey();
        }
    }
}
