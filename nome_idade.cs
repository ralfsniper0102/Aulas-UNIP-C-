using System;

namespace ConsoleApp1
{
    class Programa
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Olá, qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("E qual a sua idade?");

            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}, você tem {1} anos de idade.", nome, idade);

            Console.ReadKey();
        }
    }
}