using System;

namespace ConsoleApp1
{
    class Programa
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Digite um numero de 1 a 4");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Você digitou um");
                    break;
                case 2:
                    Console.WriteLine("Você digitou dois");
                    break;
                case 3:
                    Console.WriteLine("Você digitou três");
                    break;
                case 4:
                    Console.WriteLine("Você digitou quatro");
                    break;
                default:
                    Console.WriteLine("Você não digitou a opção correta");
                    break;
            }
            Console.ReadKey();
        }
    }
}
